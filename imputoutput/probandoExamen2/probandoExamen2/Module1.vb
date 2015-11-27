Module Module1
    Dim num As Integer
    Dim matriz() As Integer
    Dim cont As Boolean
    Dim rnd As Random = New Random()


    Sub entradaDeDatos()
        Console.WriteLine("introduce el tamaño que va a tener nuestro array: ")
        Do
            Try
                num = Integer.Parse(Console.ReadLine)
                If num < 1 Then
                    Console.WriteLine("El numero tiene que ser positivo, Intentalo de nuevo!!")
                    cont = True
                Else
                    Console.WriteLine("Numero aceptado")
                    cont = False
                End If

            Catch ex As Exception
                e2ewe2      Console.WriteLine("No has introducido un valor numerico, intentalo de nuevo!!!")
                cont = True

            End Try

        Loop While (cont)
    End Sub

    Sub Main()
        entradaDeDatos()
        ReDim matriz(num)
        For Each n1 As Integer In matriz
            num = 0
            matriz(num) = rnd.Next(1, 10)


            num += 1
        Next

        For Each n1 As Integer In matriz
            Console.WriteLine(matriz(n1))
        Next

        Console.WriteLine("pulsa una tecla
")
        Console.ReadKey()
    End Sub

End Module
