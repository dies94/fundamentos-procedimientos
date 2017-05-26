Module tres_siete

    Enum Operaciones
        suma = 1
        resta = 2
        multiplicacion = 3
        division = 4
    End Enum

    Sub main()

        Console.WriteLine("El resultado de suma es: " & calcular(Operaciones.suma, 1, 2))
        Console.WriteLine("El resultado de resta es: " & calcular(Operaciones.resta, 1, 2, 3))
        Console.WriteLine("El resultado de mltiplicacion es: " & calcular(Operaciones.multiplicacion, 1, 2, 3, 4))
        Console.WriteLine("El resultado de divicion es: " & calcular(Operaciones.division, 1.43, 2, 3, 4))
        Console.WriteLine("El resultado de suma sin enum es: " & calcular(1, 2, 3))
        Console.ReadKey()

    End Sub

    Private Function calcular(suma As Operaciones, num1 As Integer, num2 As Integer) As Integer

        Return num1 + num2

    End Function

    Private Function calcular(resta As Operaciones, num1 As Integer, num2 As Integer, num3 As Integer) As Integer

        Return num1 - num2 - num3

    End Function

    Private Function calcular(multiplicacion As Operaciones, num1 As Integer, num2 As Integer, num3 As Integer, ByVal num4 As Integer) As Integer

        Return num1 * num2 * num3 * num4

    End Function

    Private Function calcular(divicion As Operaciones, num1 As Double, num2 As Integer, num3 As Integer, num4 As Integer) As Double

        Return num1 / num2 / num3 / num4

    End Function

    Private Function calcular(num1 As Integer, num2 As Integer, num3 As Integer) As Integer

        Return calcular(Operaciones.suma, num1, num2) + num3

    End Function

End Module
