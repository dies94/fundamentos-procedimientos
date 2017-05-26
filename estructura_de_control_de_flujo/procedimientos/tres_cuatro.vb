Module tres_cuatro

    Sub main()

        Dim A, B, C As Single


        Do
            A = Console.ReadLine
            B = Console.ReadLine

            C = calculo(A, B)

        Loop Until validar(A, B)

        Console.WriteLine("La hipotenusa es: " & C)

        Console.ReadKey()

    End Sub

    Private Function validar(A As Single, B As Single)
        Dim subA, subB As Integer

        If Math.Round(A, subA) = A And A > 0 And Math.Round(B, subB) = B And B > 0 Then

            Return True
        Else
            Return False
        End If

    End Function

    Private Function calculo(A, B)

        Dim C As Integer

        C = A ^ 2 + B ^ 2

        Return C

    End Function



End Module
