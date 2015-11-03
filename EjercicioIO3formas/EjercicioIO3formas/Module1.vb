Imports System.IO
Imports System.Text

Module Module1

    Dim path As String = "D:\Desarollo de sistemas\GITHUB\Visual_Basic\EjercicioIO3formas\"

    Structure persona
        Dim nombre As String
        Dim direccion As String
        Dim telefono As Double
        Dim mail As String
    End Structure

    Sub pedirPath()
        Console.WriteLine("Escribe el nombre del archivo donde quieres guardar la informacion: ")
        Dim archivo As String = Console.ReadLine
        path = path + archivo
    End Sub




    Sub Main()
        'abrimos un flujo




        System.Threading.Thread.Sleep(1500)
    End Sub

End Module
