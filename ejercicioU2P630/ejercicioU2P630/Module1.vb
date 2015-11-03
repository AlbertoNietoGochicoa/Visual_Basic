Imports System.IO
Imports System.Text

Module Module1

    Dim texto As String
    Dim path As String = "D:\Desarollo de sistemas\GITHUB\Visual_Basic\ejercicioU2P630\"
    Dim archivo As String

    Sub pedirTexto()
        Console.WriteLine("Escribe lo que quieres guardar: ")
        texto = Console.ReadLine
    End Sub
    Sub pedirPath()
        Console.WriteLine("Escribe el nombre del archivo donde deseas guardar el texto escrito: ")
        archivo = Console.ReadLine
        Path = Path + archivo + ".txt"
    End Sub

    Sub guardarTexto()

        Dim fs = New FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim bw = New BinaryWriter(fs)
        bw.Write(texto)

        fs.Close()
    End Sub

    Sub leerTexto()
        Dim fs = New FileStream(path, FileMode.Open, FileAccess.Read)
        Dim br = New BinaryReader(fs)
        While (True)
            texto = br.ReadString()
        End While

        fs.Close()
    End Sub

    Sub Main()


        Try

            pedirPath()
            pedirTexto()
            guardarTexto()
            leerTexto()



        Catch e As EndOfStreamException
            Console.WriteLine("Fin del fichero...")
        Catch e As IOException
            Console.WriteLine("Error imprevisto: " + e.Message)
        Catch e As Exception
            Console.WriteLine("Otro Error imprevisto: " + e.Message)
        Finally

        End Try

        System.Threading.Thread.Sleep(2500)
    End Sub

End Module
