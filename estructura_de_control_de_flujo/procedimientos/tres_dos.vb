﻿Module tres_dos

    Sub main()

        Dim fecha As Datetime = Console.ReadLine()
        Dim dia As Integer = Console.ReadLine()

        fecha = sumafecha(fecha, dia)

        Console.WriteLine(fecha.Day & "/" & fecha.Month & "/" & fecha.Year)



        Console.ReadKey()
    End Sub

    Private Function sumafecha(fecha As Date, dia As Integer)

        Dim resultado As DateTime

        'DateAdd suma dias a la fecha 
        resultado = DateAdd(DateInterval.Day, dia, fecha)

        Return resultado

    End Function

End Module
