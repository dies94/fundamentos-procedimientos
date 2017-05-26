Module cuatro_cuatro

    Sub main()

        Dim pais As New Collection
        Dim dominio As String

        pais.Add("argentina", "ar")
        pais.Add("paraguay", "py")
        pais.Add("uruguay", "uy")

        Console.WriteLine("ingrese dominio de pais: ")
        dominio = Console.ReadLine()

        While dominio <> ""

            Console.WriteLine(pais.Item(dominio))

            Console.WriteLine("ingrese dominio de pais: ")
            dominio = Console.ReadLine()

        End While





    End Sub

End Module
