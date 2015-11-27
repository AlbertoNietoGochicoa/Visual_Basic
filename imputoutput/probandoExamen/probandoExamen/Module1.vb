
Module Module1
    Dim num As Integer
    Dim cont As Boolean
    Dim total As Integer = 8


    Sub leerEntero()
        Try
            num = Integer.Parse(Console.ReadLine())
            If num < 1 Then
                Console.WriteLine(">Por favor elige una opcion valida !!!!!!!!!!!!!!!!!!!!!!!!!!!!!")
                cont = True
            Else
                cont = False
                Console.WriteLine("opcion acertada")

            End If
        Catch ex As Exception
            Console.WriteLine("No has insertado un numero, intentalo de nuevo!!")
            cont = True
        End Try
    End Sub

    Sub entradaDatos()
        Console.Clear()

        Do
            Console.WriteLine("Introduce un numero: ")
            leerEntero()
        Loop While (cont)

    End Sub

    Sub procesoMultiplo8()

        While total < num
            Console.WriteLine("-> " & total)
            total += 8
            System.Threading.Thread.Sleep(100)
        End While

    End Sub

    Sub Main()


        entradaDatos()
        procesoMultiplo8()
        Console.WriteLine("pulsa una tecla para salir")
        Console.ReadKey()
        System.Threading.Thread.Sleep(1500)
    End Sub

End Module
