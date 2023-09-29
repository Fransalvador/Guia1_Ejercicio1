Module Module1

    Sub Main()
        ' Solicitar al usuario que ingrese la hora en formato "hh:mm"
        Console.Write("Ingresa la hora en formato hh:mm: ")
        Dim horaMinuto As String = Console.ReadLine()

        ' Separar la hora y los minutos
        Dim partes As String() = horaMinuto.Split(":")

        If partes.Length <> 2 Then
            Console.WriteLine("El formato de la hora ingresada no es válido.")
        Else
            ' Obtener las horas y los minutos
            Dim horas As Integer
            Dim minutos As Integer

            If Integer.TryParse(partes(0), horas) AndAlso Integer.TryParse(partes(1), minutos) Then
                ' Calcular el tiempo en diferentes tiempos
                Dim tiempoEnSegundos As Double = (horas * 3600) + (minutos * 60)
                Dim tiempoEnMinutos As Double = (horas * 60) + (minutos)
                Dim tiempoEnHoras As Double = (horas) + (minutos / 60)

                ' distancia dada en kilometros en el enunciado
                Dim distanciaEnKilometros As Double = 42195
                Dim distanciaEnMetros As Double = distanciaEnKilometros * 1000

                ' Calcular la velocidad
                Dim velocidadKMXh As Double = distanciaEnKilometros / tiempoEnHoras
                Dim velocidadKMXmin As Double = distanciaEnKilometros / tiempoEnMinutos
                Dim velocidadKMXs As Double = distanciaEnKilometros / tiempoEnSegundos
                Dim velocidadMXmin As Double = distanciaEnMetros / tiempoEnMinutos
                Dim velocidadMXs As Double = distanciaEnMetros / tiempoEnSegundos

                ' Mostrar la velocidad calculada
                Console.WriteLine("La velocidad del corredor es: " & Math.Round(velocidadKMXh, 2) & " Kilometros por Hora")
                Console.WriteLine("La velocidad del corredor es: " & Math.Round(velocidadKMXmin, 2) & " Kilometros por minutos")
                Console.WriteLine("La velocidad del corredor es: " & Math.Round(velocidadKMXs, 2) & " Kilometros por segundos")
                Console.WriteLine("La velocidad del corredor es: " & Math.Round(velocidadMXmin, 2) & " metros por minutos")
                Console.WriteLine("La velocidad del corredor es: " & Math.Round(velocidadMXs, 2) & " metros por segundo")

            Else
                Console.WriteLine("El formato de la hora ingresada no es válido.")
            End If
        End If
        Console.WriteLine("")
        Console.WriteLine("Alumno: Francisco Salvador Moreno Garcia     Carnet: MG1250012022")
        ' Pausar la consola para que el usuario pueda ver el resultado
        Console.ReadLine()
    End Sub

End Module
