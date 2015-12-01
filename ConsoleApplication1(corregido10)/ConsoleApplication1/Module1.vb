Module Module1

    Dim opcion As Integer
    Dim n1 As Integer
    Dim n2 As Integer
    Dim total As Integer
    Dim nombres As ArrayList = New ArrayList
    Dim sueldos As ArrayList = New ArrayList
    Dim maxSal As Integer = Integer.MinValue
    Dim minsal As Integer = Integer.MaxValue
    Dim cont As Boolean

    Private Sub leerEnteromenu()
        Do
            Try
                opcion = Integer.Parse(Console.ReadLine)
                cont = False
            Catch ex As Exception
                Console.WriteLine("ERROR!! No has insertado un nuemro, intentelo otra vez!!!" & vbCrLf &
                                  "opcion: ")
                cont = True
            End Try
        Loop While (cont)

    End Sub
    Sub entradaDatos()
        Do
            Console.WriteLine("Por favor introduce 1 numero entero : ")
            Try
                n1 = Integer.Parse(Console.ReadLine)
                Console.WriteLine("Por favor introduce otro numero entero mayor que el anterior : ")
                n2 = Integer.Parse(Console.ReadLine)
                If n1 < 0 Or n2 < 0 Then
                    Console.WriteLine("Has insertado un numero negativo, intentalo otra vez desde el principio!!!")
                    cont = True
                Else
                    cont = False
                End If
            Catch ex As Exception
                Console.WriteLine("ERROR, ERROR, no has introducido un numero entero, Intentalo otra vez desde el principio!!!")
                cont = True
            End Try
        Loop While cont

    End Sub
    Private Sub sumarMultiplosDeCinco()
        total = 0
        'pruebas varias....
        ' Console.WriteLine(n1 & "  -  " & n2 & "   -  " & total)
        'Console.WriteLine("pulsa una tecla")
        'console.ReadKey()

        'Dim i As Integer = 1

        'While (n1 < n2)
        'total = total + (5 * i)
        'n1 = n1 + 5
        'i = i + 1
        'nd While

        total = 0
        For i = n1 To n2
            If i Mod 5 = 0 Then
                total += 1

            End If
        Next


    End Sub
    Private Sub visualizarSuma()
        Console.WriteLine("La suma de los multiplos de 5 comprendidos entre los numeros introducidos es: " & vbCrLf & "total= " & total)
        Console.WriteLine("pulsa una tecla para continuar....")
        Console.ReadKey()
        Console.Clear()
    End Sub

    Private Sub problema1()
        entradaDatos()

        If n1 > n2 Then
            Dim aux As Integer = n1
            n1 = n2
            n2 = aux
        Else
            Console.WriteLine("Datos introducidos correctamente!!" & vbCrLf)
        End If
        sumarMultiplosDeCinco()
        visualizarSuma()



    End Sub
    Private Sub maxSueldo()
        'creo una variable para guardar la posicion para sacar el nombre del salario mas alto
        Dim j As Integer = 0
        Dim contador = 0

        For Each element As Integer In sueldos
            If element > maxSal Then
                maxSal = element
                j = contador
            End If
            contador += 1
        Next
        Console.WriteLine("La persona con el salario mas alto es: " & nombres(j))
        Console.WriteLine("el salario mas alto es: " & maxSal)
    End Sub
    Private Sub minSueldo()
        'creo una variable para guardar la posicion para sacar el nombre del salario mas 
        Dim j As Integer = 0
        Dim contador = 0

        For Each element As Integer In sueldos
            If element < minsal Then
                minsal = element
                j = contador
            End If
            contador += 1
        Next
        Console.WriteLine(vbCrLf & "La persona con el salario mas bajo es: " & nombres(j))
        Console.WriteLine("el salario mas bajo es: " & minsal)
    End Sub

    Private Sub problema2()

        Do
            Try


                Console.Write("Introduce el nombre de una persona: " & vbCrLf &
                              "nombre: ")
                Dim nom As String = Console.ReadLine
                nombres.Add(nom)
                Console.WriteLine("Introduce el salario de   " & nom & ":" & vbCrLf &
                                  "Salario: ")
                Try
                    sueldos.Add(Integer.Parse(Console.ReadLine))
                Catch ex As Exception
                    Console.WriteLine("No has escrito un numero.... siesque.....")
                End Try


            Catch ex As Exception
                Console.WriteLine("ERROR, ERROR, algo has hecho mal....!!!!")
            End Try

            'Se pregunta si se quiere seguir introduciendo datos...
            Try


                Console.WriteLine("deseas segir introduciendo datos??")
                Dim resp As String = Console.ReadLine
                If resp <> ("no") Then

                    cont = True
                    Else

                        cont = False
                End If
            Catch ex As Exception

            End Try
        Loop While cont
        'sacamos por pantalla los resultados....
        maxSueldo()
        minSueldo()

        Console.WriteLine("pulsa una tecla para seguir...")
        Console.ReadKey()

    End Sub
    Sub Main()

        'mostramos menu
        Do
            Console.WriteLine("elige una opcion: " & vbCrLf &
                          "1->problema 1" & vbCrLf &
                          "2->Problema 2" & vbCrLf &
                          "3->Salir")
            leerEnteromenu()
            'gestionamos la opcion elegida...
            Select Case opcion
                Case 1
                    problema1()
                Case 2
                    problema2()
                Case 3
                    'salimos del programa cariñosamente...
                    Console.WriteLine(" Muchas gracias por usar este maravilloso programa, Que tengas un buen dia!!!!!")
                    System.Threading.Thread.Sleep(1500)
                Case Else
                    Console.WriteLine("Elige un numero del 1 al 3!!!!" & vbCrLf &
                                      "opcion: ")
            End Select


        Loop While (opcion <> 3)
    End Sub

End Module
