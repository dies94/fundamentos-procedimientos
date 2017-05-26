Module dos_once

    Sub main()
        Dim pares, impares As Integer
        Dim ingreso As Integer

        Do

            ingreso = Console.ReadLine

            If (ingreso Mod 2) <> 0 Then
                impares += 1
            Else
                pares += 1
            End If

            If ingreso < 0 Then
                Continue Do
            End If

        Loop While ingreso

        If pares = 0 Then
            Console.WriteLine("Todos los numero ingresados son pares: " & pares)
        ElseIf impares = 0 Then
            Console.WriteLine("Todos los numero ingresados son inpares: " & impares)
        Else
            Console.WriteLine("Numero pares ingresados pares: " & pares)
            Console.WriteLine("Numero pares ingresados inpares: " & impares)

        End If


    End Sub

End Module
