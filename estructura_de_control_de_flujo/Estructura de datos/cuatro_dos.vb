Module cuatro_dos

    Sub main()

        Dim codigo = New Integer() {123, 789, 456}
        Dim nombre = New String() {"Caramelo", "Galletita", "Jugo"}
        Dim precio = New Single() {2.5, 10, 20.65}

        Dim opcion, cantidad, cuenta As Integer
        Dim total, totalgenearl As Single


        Do

            Console.Write("ingrese codigo del producto (para salir igrese 0 ): ")
            opcion = Console.ReadLine()

            For Each x As Integer In codigo

                If opcion = x Then

                    Console.WriteLine("descripcion:{0} precio unitario: {1}", nombre(cuenta), precio(cuenta))

                    Console.Write("cantidad: ")
                    cantidad = Console.ReadLine

                    total = cantidad * precio(cuenta)
                    Console.WriteLine("Total: " & total)

                End If
                cuenta += 1
            Next

            totalgenearl = total + totalgenearl
            Console.WriteLine("Total general: " & totalgenearl)

            Console.WriteLine("-----------------------------------------")

            cuenta = 0
        Loop While opcion



        Console.ReadKey()
    End Sub

End Module
