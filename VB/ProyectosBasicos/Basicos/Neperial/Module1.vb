Module Module1

    Sub Main()
        ' Variables a utilizar
        Dim Neperial As Double = 0
        Dim Ingresado As String
        Dim Precision As Integer
        Dim Termino As Integer

        ' Pido ingresar la cantidad de términos de la serie numérica
        Console.Write("Ingrese la precisión deseada (cantidad de términos de la serie numérica): ")
        Ingresado = Console.ReadLine()

        ' Verifico que lo ingresado sea un valor numérico
        VerificarValorNumerico(Ingresado, Precision)

        ' Verifico que el valor ingresado sea un número válido
        VerificarPrecisionIngresada(Precision)

        ' Cálculo del número neperial
        For Termino = 0 To Precision
            Neperial = Neperial + (1 / Factorial(Termino))
        Next

        ' Muestro resultado
        Console.WriteLine("Neperial aproximado a {0} términos: {1}", Precision, Neperial)
        Console.WriteLine()
        Console.Write("Presione una tecla para continuar...")
        Console.ReadLine()
    End Sub

    Private Sub VerificarValorNumerico(Numero As String, ByRef Precision As Integer)
        Dim EsNumero As Integer

        Integer.TryParse(Numero, EsNumero)

        If (EsNumero = 0) Then
            Console.WriteLine("La precisión de la serie debe ser un número entero mayor a igual a cero.")
            Console.Write("Saliendo")
            Threading.Thread.Sleep(1000)
            Console.Write(".")
            Threading.Thread.Sleep(1000)
            Console.Write(".")
            Threading.Thread.Sleep(1000)
            Console.Write(".")
            Threading.Thread.Sleep(1000)
            Console.Write(".")
            Threading.Thread.Sleep(1000)
            Console.Write(".")
            Threading.Thread.Sleep(1000)
            End
        Else
            Precision = Convert.ToInt32(Numero)
        End If
    End Sub

    Private Sub VerificarPrecisionIngresada(ByRef Precision As Integer)
        If (Precision <= 0) Then
            Console.WriteLine("La cantidad de términos debe ser mayor a cero.")
            Console.Write("Saliendo")
            Threading.Thread.Sleep(1000)
            Console.Write(".")
            Threading.Thread.Sleep(1000)
            Console.Write(".")
            Threading.Thread.Sleep(1000)
            Console.Write(".")
            Threading.Thread.Sleep(1000)
            Console.Write(".")
            Threading.Thread.Sleep(1000)
            Console.Write(".")
            Threading.Thread.Sleep(1000)
            End
        End If

        If (Precision > 12) Then
            Precision = 12
        End If
    End Sub

    Private Function Factorial(Numero As Double) As Double
        Dim Fact As Integer
        Dim i As Integer

        Fact = 1

        If (Numero = 0) Then
            Return 1
        Else
            For i = 1 To Numero
                Fact = Fact * i
            Next
        End If

        Return Fact
    End Function

End Module
