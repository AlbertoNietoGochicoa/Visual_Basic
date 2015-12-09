Public Class Form1


    Sub main()
        MessageBox.Show("Hola mundo")
    End Sub

    Sub turnoRojo()
        'ponemos el boton azul en su color y el rojo a gris
        botRojo.Enabled = True
        botRojo.BackColor = Color.Red

        botAzul.Enabled = False
        botAzul.BackColor = Color.Gray

    End Sub

    Sub turnoAzul()
        'Ponemos el boton Azul con su color y el rojo lo ponemos en gris
        botAzul.Enabled = True
        botAzul.BackColor = Color.Blue

        botRojo.Enabled = False
        botRojo.BackColor = Color.Gray


    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MsgBox("Bienvenidos al maravilloso mundo del tres en RAYA!!!!!!!!")

        turnoRojo()



    End Sub

    Private Sub botRojo_Click(sender As Object, e As EventArgs) Handles botRojo.Click

    End Sub

    Private Sub botAzul_Click(sender As Object, e As EventArgs) Handles botAzul.Click

    End Sub

    Private Sub bot1_Click(sender As Object, e As EventArgs) Handles bot1.Click

    End Sub

    Private Sub botSalir_Click(sender As Object, e As EventArgs) Handles botSalir.Click
        ' Botón salir
        MsgBox("Gracias por jugar al tres en raya.")
        Close()
    End Sub
End Class
