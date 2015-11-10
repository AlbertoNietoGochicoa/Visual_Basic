Module Module1

    Dim total As Integer = 8
    Dim num As Integer
    Dim i As Integer = 1

    Dim cont As Boolean

    Sub entradaDatos()
        Console.WriteLine(vbCrLf + "Por favor introduce un numero entero: ")
        leerEntero()
    End Sub

    Sub procesoMultiplosOcho()
        While (total <= num)
            Console.WriteLine(i & "->   " & total)
            total = total + 8
            i += 1
        End While
    End Sub

    Sub leerEntero()
        Do
            Try
                'recogemos el valor 
                Console.Write(vbCrLf & "Numero: ")
                num = Integer.Parse(Console.ReadLine)

                'validamos que el numero sea positivo
                If (num < 8) Then
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
        Console.WriteLine("Bienvenido a la prueba de examen" + vbCrLf +
                          "Este programa te va a enseñar todos los multiplos de ocho que hay hasta el numero que tu introduzcas!!!")

        entradaDatos()
        procesoMultiplosOcho()

        System.Threading.Thread.Sleep(2500)
    End Sub

End Module
