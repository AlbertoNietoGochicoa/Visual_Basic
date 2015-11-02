Imports System.IO
Imports System.Text



Module Module1

    Dim nombre As String
    Dim lup As FileStream
    Dim lup1 As StreamReader
    Dim texto As Byte()
    Sub Main()


        My.Computer.FileSystem.WriteAllText("c:\users\lenovo\documents\visual studio 2015\Projects\imputoutput\ejercicioP6E20\ejercicioP6E20\lupen.txt", "ola que ase", True)

        Dim cadena As String
        cadena = My.Computer.FileSystem.ReadAllText("c:\users\lenovo\documents\visual studio 2015\Projects\imputoutput\ejercicioP6E20\ejercicioP6E20\lupen.txt")
        MsgBox(cadena)

    End Sub

End Module
