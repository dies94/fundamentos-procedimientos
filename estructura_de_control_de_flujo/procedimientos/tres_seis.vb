Module tres_seis

    Sub main()

        Dim total As Integer
        Dim N As Single

        Do

            Console.Write("ingrese un numero: ")
            N = Console.ReadLine()

        Loop Until validar(N)

        sumatoria(N, total)

        Console.WriteLine("Total sumatoria de los cuadrado ente 1 Y N: " & total)

        Console.ReadKey()

    End Sub

    Private Function validar(ByVal N As Single)

        Dim subN As Integer

        If Math.Round(N, subN) = N And N > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub sumatoria(ByRef N As Single, ByRef total As Single)

        For x As Integer = 1 To N

            total += x ^ 2

        Next



    End Sub

End Module
