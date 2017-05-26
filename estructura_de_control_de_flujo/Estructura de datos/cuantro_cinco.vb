Module cuantro_cinco

    Sub main()
        Dim pais As New Collection
        Dim dominio, nombre As String
        Dim opcion As Integer

        Do
            Console.WriteLine("1=agregar")
            Console.WriteLine("2=editar")
            Console.WriteLine("3=eliminar")
            Console.WriteLine("4=buscar pais")
            Console.WriteLine("5=paises agregados")
            Console.WriteLine("0=salir")

            opcion = Console.ReadLine()

            Select Case opcion
                Case 1

                    agrega(pais, nombre, dominio)
                    Console.WriteLine("pais agregado")

                Case 2
                    Console.WriteLine("ingrese dominio de pais que decea editar: ")
                    dominio = Console.ReadLine()

                    pais.Remove(dominio)

                    agrega(pais, nombre, dominio)
                    Console.WriteLine("pais editado")

                Case 3
                    Console.WriteLine("que pais decea eliminar: ")
                    dominio = Console.ReadLine
                    Console.WriteLine("el pais que elimino es: " & pais.Item(dominio))
                    pais.Remove(dominio)

                Case 4
                    Console.WriteLine("ingrese el dominio del pais que decea buscar: ")
                    dominio = Console.ReadLine

                    Console.WriteLine("el pais que busco es: " & pais.Item(dominio))

                Case 5
                    Console.WriteLine("catidad de paises agregados: " & pais.Count)

            End Select

        Loop While opcion

    End Sub

    Private Sub agrega(pais As Collection, nombre As String, dominio As String)

        Console.WriteLine("ingrese nombre de pais: ")
        nombre = Console.ReadLine()
        Console.WriteLine("ingrese dominio de pais")
        dominio = Console.ReadLine()
        pais.Add(nombre, dominio)

    End Sub
End Module
