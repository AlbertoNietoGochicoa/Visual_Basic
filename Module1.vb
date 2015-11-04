Imports System.IO
Imports System.Text

Module Module1

    Dim cont As Boolean
    Dim path As String = "C:\Users\gyga\Google Drive\Alberto\DI\ioPersonas\"

    Structure persona
        Dim nombre As String
        Dim direccion As String
        Dim telefono As Integer
        Dim correo As String
    End Structure

    Sub pausar()
        System.Threading.Thread.Sleep(1500)
    End Sub

    Sub continuar()
        Try
            Dim continuar As Boolean
            Do
                Console.WriteLine("Quieres introducir otra persona en la base de datos?? S/N")
                Dim respuesta = (Console.ReadLine).ToLower
                Select Case respuesta
                    Case "s"
                        continuar = False
                        cont = True
                    Case "n"
                        continuar = False
                        cont = False
                    Case Else
                        Console.Clear()
                        Console.WriteLine("No has tecleado una opcion valida" + vbCrLf)
                        continuar = True
                End Select
            Loop While (continuar)
        Catch ex As Exception
            Console.WriteLine("ERROR de excepcion!!!")
        End Try

    End Sub
    Sub crearArchivo()


    End Sub

    Sub Main()

        Console.Write("Muy buenas, bienvenido a la base de datos 2.0!!" + vbCrLf)

        Do


            continuar()
        Loop While (cont)
        pausar()
    End Sub
End Module
