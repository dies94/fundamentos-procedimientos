Module dos_cuatro
    Enum descuentos As Integer

        menor = 5
        medio = 10
        mayor = 20

    End Enum
    Sub main()
        Dim montodesc As Single
        Dim cantidad As Single = Console.ReadLine
        Dim precio As Single = Console.ReadLine

        If cantidad >= 10 And cantidad <= 50 Then

            montodesc = precio * descuentos.menor / 100

            Console.WriteLine("porcentaje de descuento: " & descuentos.menor & "%")
        ElseIf cantidad >= 51 And cantidad <= 250 Then

            montodesc = precio * descuentos.medio / 100

            Console.WriteLine("porcentaje de descuento: " & descuentos.menor & "%")
        Else

            montodesc = precio * descuentos.mayor / 100

            Console.WriteLine("porcentaje de descuento: " & descuentos.menor & "%")

        End If

        Console.WriteLine("Subtotal: " & cantidad * precio)
        Console.WriteLine("Monto descontado: " & montodesc)
        Console.WriteLine("Total: " & precio - montodesc)

        Console.ReadKey()

    End Sub

End Module
