Module Module1

    Sub Main()
        Dim Numero As Integer
        Dim Factorial As Integer
        Dim i As Integer

        Console.Write("Ingrese el número a calcular el factorial: ")
        Numero = Console.ReadLine()

        Factorial = 1

        For i = 1 To Numero
            Factorial = Factorial * i
        Next

        Console.WriteLine("Factorial de {0} = {1}", Numero, Factorial)
        Console.WriteLine()
        Console.Write("Presione una tecla para continuar...")
        Console.ReadLine()
    End Sub

End Module
