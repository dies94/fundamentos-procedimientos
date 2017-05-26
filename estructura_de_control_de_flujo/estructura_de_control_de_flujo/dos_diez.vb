Module dos_diez

    Sub main()

        Dim multiplos As Integer
        Dim menor As Integer = Console.ReadLine
        Dim mayor As Integer = Console.ReadLine
        Dim retiene As Integer = mayor
        ''''''''''''''''''for'''''''''''''''''''''''''''''''''''''''''''
        For x As Integer = 5 To mayor Step 5


            If 0 = menor Mod x Then
                multiplos += 1
            End If
            multiplos += 1

        Next

        Console.WriteLine("multiplos entre ellos son: " & multiplos)

        Console.ReadKey()
        '''''''''''''''''''''''''''do loop while'''''''''''''''''''''''''''''''''''''''''''
        multiplos = 0

        Do

            If 0 = menor Mod mayor Then
                multiplos += 1
            End If
            multiplos += 1

            mayor -= 5

        Loop While mayor

        Console.WriteLine("multiplos entre ellos son: " & multiplos)

        Console.ReadKey()
        '''''''''''''''''''''''''''''''''''do while''''''''''''''''''''''''''''''''''''''''
        mayor = retiene
        multiplos = 0

        Do While mayor

            If 0 = menor Mod mayor Then
                multiplos += 1
            End If
            multiplos += 1

            mayor -= 5
        Loop


        Console.WriteLine("multiplos entre ellos son: " & multiplos)

        Console.ReadKey()
        '''''''''''''''''''''''do until'''''''''''''''''''''''''''''''''''''''''''
        mayor = retiene
        multiplos = 0

        Do Until mayor = 0

            If 0 = menor Mod mayor Then
                multiplos += 1
            End If
            multiplos += 1

            mayor -= 5
        Loop





        Console.WriteLine("multiplos entre ellos son: " & multiplos)

        Console.ReadKey()
        '''''''''''''''''''''''do loop until'''''''''''''''''''''''''''''''''''''''''''
        mayor = retiene
        multiplos = 0


        Do
            If 0 = menor Mod mayor Then
                multiplos += 1
            End If
            multiplos += 1

            mayor -= 5
        Loop Until mayor = 0

        Console.WriteLine("multiplos entre ellos son: " & multiplos)

        Console.ReadKey()

    End Sub

End Module
