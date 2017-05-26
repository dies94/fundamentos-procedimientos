Module tres_ocho

    Enum Operaciones
        suma = 1
        resta = 2
        multiplicacion = 3
        division = 4
    End Enum

    Sub main()


        resultado(Operaciones.suma, 1, 2)
        resultado(Operaciones.resta, 1, 2, 3)
        resultado(Operaciones.multiplicacion, 1, 2, 3, 4)
        resultado(Operaciones.division, 1.43, 2, 3, 4)


        Console.ReadKey()

    End Sub

    Sub resultado(suma As Operaciones, num1 As Integer, num2 As Integer)

        Console.WriteLine("El resultado de suma es: " & calcular(Operaciones.suma, num1, num2))

    End Sub

    Sub resultado(resta As Operaciones, num1 As Integer, num2 As Integer, num3 As Integer)

        Console.WriteLine("El resultado de resta es: " & calcular(Operaciones.resta, num1, num2, num3))

    End Sub

    Sub resultado(multiplicacion As Operaciones, num1 As Integer, num2 As Integer, num3 As Integer, num4 As Integer)

        Console.WriteLine("El resultado de multiplicacion es: " & calcular(Operaciones.multiplicacion, num1, num2, num3, num4))

    End Sub

    Sub resultado(divicion As Operaciones, num1 As Double, num2 As Integer, num3 As Integer, num4 As Integer)

        Console.WriteLine("El resultado de divicion es: " & calcular(Operaciones.division, num1, num2, num3, num4))

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

End Module
