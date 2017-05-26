Module cuatro_tres

    Sub main()

        Dim cantidad_alumnos, cantidad_notas As Integer
        Dim promedio, ingresanota As Single
        Dim ingreaalumno As String

        alumnosynotas(cantidad_alumnos, cantidad_notas)

        Dim alumno(cantidad_alumnos - 1) As String
        Dim nota(cantidad_notas - 1) As Single
        Dim promedioalto(cantidad_alumnos - 1) As Single


        For iteraralumno As Integer = 0 To alumno.Length - 1

            Console.WriteLine("ingrese nombre del alumnos: ")
            ingreaalumno = Console.ReadLine()




            If nombre_repetido(ingreaalumno, alumno) And nombre_vacio(ingreaalumno) Then
                alumno(iteraralumno) = ingreaalumno
            Else
                Continue For
            End If


            For Each iterarnota As Integer In nota

                Console.WriteLine("ingrese la nota del alumno: ")
                ingresanota = Console.ReadLine()
                nota(iterarnota) = ingresanota

                nota_repetida(nota, ingresanota, cantidad_notas)

                promedio += nota(iterarnota)


            Next

            ReDim nota(cantidad_notas - 1)

            promedio = calcula_promedio(promedio, cantidad_notas)

            Console.WriteLine("alumno: {0} | promedio: {1}", alumno(iteraralumno), promedio)

            aprobar(promedio)

            promedioalto(iteraralumno) = promedio

            promedio = 0

        Next

        Console.WriteLine(subpromoedios(promedioalto, alumno))

        Console.ReadKey()
    End Sub

    'verifica si el nombre esta vacio
    Private Function nombre_vacio(ingresaalumno As String)

        If ingresaalumno = Nothing Then
            Return False
            Console.WriteLine("el nombre esta vacio")
        Else
            Return True
        End If


    End Function

    'verifica si el nombre es repetido
    Private Function nombre_repetido(ingresaalumno As String, alumno() As String)

        If alumno.Contains(ingresaalumno) Then
            Return False
            Console.WriteLine("el nombre ingresado ya existe")
        Else
            Return True
        End If

    End Function

    'verifica si el rango de notas es repetido
    Private Sub nota_repetida(nota() As Single, ingresanota As Single, cantidad_notas As Integer)

        Dim acumula As Byte

        If nota.Contains(ingresanota) Then
            acumula += 1
        End If

        If cantidad_notas = acumula Then
            Console.WriteLine("el rango de notas es repetido")
        End If

    End Sub

    'calcula el promedio
    Private Function calcula_promedio(promedio As Single, cantidad_notas As Integer)
        Return promedio / cantidad_notas
    End Function

    'verifica si aprobo o no
    Private Sub aprobar(promedio)

        If promedio >= 6 Then
            Console.WriteLine("Aprobo")
        Else
            Console.WriteLine("No aprbo")
        End If

    End Sub

    Private Sub alumnosynotas(ByRef alumnos As Integer, ByRef notas As Single)

        Console.WriteLine("ingrese catidad de alumnos: ")
        alumnos = Console.ReadLine()
        Console.WriteLine("ingrese catidad de notas: ")
        notas = Console.ReadLine()

        If alumnos > 40 And notas > 4 Then
            Console.WriteLine("se exedio la catidad de alumnos(40) o la cantidad de notas(4)")
        End If


    End Sub

    'calcula el promedio mas alto
    Private Function subpromoedios(promedio() As Single, alumno() As String)

        Dim subindiciepormedio(promedio.Length), subindicenombre(promedio.Length) As String
        Dim num As Single

        For x As Integer = 0 To promedio.Length - 1

            If num < promedio(x) Then
                num = promedio(x)

                ReDim subindiciepormedio(promedio.Length)
                ReDim subindicenombre(promedio.Length)

                subindiciepormedio(x) = promedio(x)
                subindicenombre(x) = alumno(x)

            ElseIf num = promedio(x) Then

                subindiciepormedio(x) = promedio(x)
                subindicenombre(x) = alumno(x)

            End If
        Next

        For x As Integer = 0 To subindiciepormedio.Length - 1
            If subindicenombre(x) <> Nothing Then

                Return "Alumno: " + subindicenombre(x) + "  Mejor Promedio: " + subindiciepormedio(x)

            End If
        Next


    End Function

End Module