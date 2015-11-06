Imports System.IO
Imports System.Text

Module Module1

    Dim cont As Boolean
    Dim path As String = "C:\Users\gyga\Documents\GitHub\Visual_Basic\imputoutput\ejercicio2.26.2\lupen.txt"

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


    Sub introducirPersona()

        Dim sw As New StreamWriter(path, True)
        Dim per As persona
        Try
            Console.WriteLine(vbCrLf + "Escribe el nombre de la persona a guardar: ")
            per.nombre = Console.ReadLine
            Console.WriteLine(vbCrLf + "Escribe la direccion de la persona: ")
            per.direccion = Console.ReadLine
            Console.WriteLine(vbCrLf + "Escribe el telefono : ")
            Try
                per.telefono = Integer.Parse(Console.ReadLine)

            Catch ex As Exception
                Console.WriteLine("Tenias que intoducir un numero!!")
            End Try
            Console.WriteLine(vbCrLf + "Escribe el correo electronico : ")
            per.correo = Console.ReadLine

            sw.WriteLine("Nombre: " + per.nombre)
            sw.WriteLine("Direccion: " + per.direccion)
            'Aqui salta la excepcion y no se por que???????????????????????????????????????????????????????????????
            Try
                sw.WriteLine("Telefono: " + per.telefono)

            Catch ex As Exception
                Console.WriteLine("ERROR al insertar el numero de telefono")
                pausar()
            End Try


            sw.WriteLine("Correo electronico: " + per.correo)
            sw.WriteLine("________________________________________________________________________________" + vbCrLf)
        Catch ex As Exception

        End Try
        sw.Close()
        Console.WriteLine("Persona guardada correctamente!!!" + vbCrLf)
    End Sub

    Sub leerPersonas()
        Dim sr As New StreamReader(path)
        Try
            Console.Clear()

            Console.WriteLine(sr.ReadToEnd)
        Catch ex As IOException
            Console.WriteLine("IO exception!!!")
        Catch ex As Exception
            Console.WriteLine("ERROR, salto la excepcion!!!")
        End Try
        sr.Close()
    End Sub


    Sub borrarArchivo()
        Dim sw As New StreamWriter(path, False)
        sw.Write("")
        sw.Close()
    End Sub

    Sub Main()
        'Empieza el programa!!
        Console.Write("Muy buenas, bienvenido a la base de datos 2.0!!" + vbCrLf)

        Do
            introducirPersona()
            leerPersonas()
            continuar()
        Loop While (cont)
        borrarArchivo()
        pausar()

    End Sub

End Module
