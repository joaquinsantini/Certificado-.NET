Module Module1

    Sub Main()
        Dim Cantidad As Integer
        Dim Divisor As Integer
        Dim Resto As Integer
        Dim Numero As Integer
        Dim EsPrimo As Boolean

        Numero = 1

        Console.Write("Ingrese la cantidad de números primos a visualizar: ")
        Cantidad = Console.ReadLine()

        While (Cantidad <> 0)
            Divisor = 2
            EsPrimo = False

            If (Numero <= Divisor) Then
                Console.WriteLine("{0} es primo.", Numero)
                Cantidad = Cantidad - 1
            Else
                While (EsPrimo <> True AndAlso Numero <> Divisor)
                    Resto = Numero Mod Divisor
                    If (Resto <> 0) Then
                        Divisor = Divisor + 1
                        If (Numero = Divisor) Then
                            EsPrimo = True
                        End If
                    Else
                        Divisor = Numero
                    End If
                End While

                If (EsPrimo = True) Then
                    Console.WriteLine("{0} es primo.", Numero)
                    Cantidad = Cantidad - 1
                End If
            End If

            Numero = Numero + 1
        End While

        Console.WriteLine()
        Console.Write("Presione una tecla para continuar...")
        Console.ReadLine()
    End Sub

End Module
