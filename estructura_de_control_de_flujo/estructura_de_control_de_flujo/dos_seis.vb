Module dos_seis

    Sub main()

        Dim montodesc As Single
        Dim cantidad As Single = Console.ReadLine
        Dim precio As Single = Console.ReadLine

        Select Case cantidad
            Case 10 To 50
                montodesc = precio * 5 / 100

                Console.WriteLine("porcentaje de descuento: 5%")
            Case 51 To 250
                montodesc = precio * 10 / 100

                Console.WriteLine("porcentaje de descuento: 10%")
            Case Is >= 251
                montodesc = precio * 20 / 100

                Console.WriteLine("porcentaje de descuento: 20%")
        End Select

        Console.WriteLine("Subtotal: " & cantidad * precio)
        Console.WriteLine("Monto descontado: " & montodesc)
        Console.WriteLine("Total: " & precio - montodesc)

        Console.ReadKey()

    End Sub

End Module
