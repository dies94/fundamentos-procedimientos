Module tres_uno

    Sub Main()
        Dim horaActual As Date

        imprimir_fecha()



        Console.WriteLine("Hora actual: " & hora_actual(horaActual))

        Console.ReadKey()
    End Sub

    Private Sub imprimir_fecha()
        Console.WriteLine("Fecha: " & Today)

    End Sub

    Private Function hora_actual(horaActual As Date)
        horaActual = TimeOfDay

        Return horaActual
    End Function

End Module
