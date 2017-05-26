Module cuatro_seis

    Sub main()
        Dim dias As New ArrayList
        Dim totaldias As New ArrayList
        Dim empelados As New Collection
        Dim totalempleado As New ArrayList
        Dim produccion, diaindice, prodindicie, diaproduccion, empproduccion As Integer
        Dim nombre, dia As String

        empelados.Add("pepito", "pe")
        empelados.Add("mauro", "ma")
        empelados.Add("lupita", "lu")

        'totalempleado.Add(0, "pe")
        'totalempleado.Add(0, "ma")
        'totalempleado.Add(0, "lu")
        totalempleado.Add(0)
        totalempleado.Add(0)
        totalempleado.Add(0)

        dias.Add("lunes")
        dias.Add("martes")
        dias.Add("miercoles")
        dias.Add("jueves")
        dias.Add("viernes")
        dias.Add("sabado")
        dias.Add("domingo")

        diaindice = dias.Count

        For x As Integer = 0 To diaindice - 1

            totaldias.Add(0)
        Next

        Do

            Console.WriteLine("ingrese dia: ")
            dia = Console.ReadLine

            If dia = "" Then
                Exit Do
            End If
            diaindice = dias.LastIndexOf(dia)


            Console.WriteLine("ingrese empelado resumido: ")
            nombre = Console.ReadLine
            nombre = empelados.Item(nombre)
            Console.WriteLine("ingresar produccion: ")
            produccion = Console.ReadLine

            empproduccion = produccion
            diaproduccion = produccion

            If totaldias.Item(diaindice) <> 0 Then
                diaproduccion = totaldias.Item(diaindice) + diaproduccion
                totaldias.RemoveAt(diaindice)
                totaldias.Insert(diaindice, diaproduccion)
            Else
                totaldias.RemoveAt(diaindice)
                totaldias.Insert(diaindice, diaproduccion)
            End If

            For x As Integer = 0 To empelados.Count
                If x Then

                    If nombre = empelados.Item(x) Then
                        prodindicie = x - 1
                    End If

                End If
            Next

            If totalempleado.Item(prodindicie) <> 0 Then

                empproduccion = totalempleado.Item(prodindicie) + empproduccion
                totalempleado.RemoveAt(prodindicie)

                totalempleado.Insert(prodindicie, empproduccion)

            Else
                totalempleado.RemoveAt(prodindicie)
                totalempleado.Insert(prodindicie, empproduccion)
            End If

        Loop While nombre <> ""

        total_produccion(totalempleado, empelados)
        total_dias(totaldias, dias)

        Console.ReadKey()
    End Sub
    Private Sub total_produccion(totalempleado, empleados)

        For x As Integer = 0 To empleados.count
            If x Then

                Console.WriteLine("nombre de empleado: " & empleados.item(x))
                Console.WriteLine("total de produccion empleado: " & totalempleado.item(x - 1))
            End If

        Next

    End Sub

    Private Sub total_dias(totaldias, dias)
        Dim cantidad As Integer
        cantidad = dias.count

        For x As Integer = 0 To cantidad - 1
            Console.WriteLine("Dia : " & dias.item(x))
            Console.WriteLine("total de produccion dia: " & totaldias.item(x))

        Next

    End Sub
End Module