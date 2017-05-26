Module cuatro_uno

    Sub Main()

        Dim arreglo(4) As Integer
        Dim media, desviacion As Integer

        For x As Integer = 0 To 4

            Console.Write("ingrese un numero: ")
            arreglo(x) = Console.ReadLine()

            media = arreglo(x) + media


        Next

        media = media / 5

        For x As Integer = 0 To 4
            Console.WriteLine("elementos del arreglo: " & arreglo(x))
            desviacion = arreglo(x) - media
            Console.WriteLine("desviacion decada elemneto: " & desviacion)
        Next


        Console.ReadKey()
    End Sub

End Module
