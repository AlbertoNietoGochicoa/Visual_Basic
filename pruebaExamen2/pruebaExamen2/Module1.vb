Module Module1

    Dim num As Integer
    Dim total As Integer
    Dim cont As Boolean
    Dim i As Integer
    Dim rnd As Random = New Random()


    Dim array() As Integer

    Sub entradaDatoConAjusteArray()
        'Solicitamos un numero y ajustamos el array a es numero.
        Console.WriteLine("Introduce un numero para ajustar el array:")
        leerEntero()
        ReDim array(num)
    End Sub

    Sub rellenarArray()
        'Se rellena el array con valores aleatorios entre el 0 y el 500
        For i = 0 To (num)
            array(i) = rnd.Next(0, 501)
        Next

    End Sub

    Sub imprimirArray()
        For i = 0 To num
            Console.WriteLine("Numero:-> " & array(i))
            System.Threading.Thread.Sleep(300)
        Next

        Console.WriteLine(vbCrLf & "Ahora del reves")

        'mirar como se puede hacer que esto de abajo funcione!!

        array.Reverse(array)



        For i = 0 To num
            Console.WriteLine("Numero:-> " & array(i))
            System.Threading.Thread.Sleep(300)
        Next


    End Sub

    Sub imprimirMaxMin()

        Console.WriteLine(vbCrLf & " El numero maximo del array es el: " & array.Max)
        Console.WriteLine(vbCrLf & " El numero maximo del array es el: " & array.Min)


    End Sub

    Sub leerEntero()
        Do
            Try
                'recogemos el valor 
                Console.Write(vbCrLf & "Numero: ")
                num = Integer.Parse(Console.ReadLine) - 1

                'validamos que el numero sea positivo
                If (num <= 0) Then
                    Console.WriteLine("ERROR, el numero introducido no es valido!!! intentalo de nuevo")
                    cont = True
                Else
                    'si es positivo continuamos
                    cont = False
                End If
                'si salta la excepcion el bucle continua
            Catch ex As Exception
                Console.WriteLine("ERROR, ERROR, ERROR!!!!!  No has introducido un numero entero, intentalo de nuevo....")
                cont = True
            End Try


        Loop While (cont)
    End Sub
    Sub Main()

        Console.WriteLine("")
        Console.WriteLine("Vamos a crear un array para introducir valores" & vbCrLf)

        entradaDatoConAjusteArray()
        rellenarArray()
        imprimirArray()
        imprimirMaxMin()

        Console.WriteLine("pulsa una tecla para salir")
        Console.ReadKey()
    End Sub

End Module
