Public Class Form1
    Dim etiqueta As String = "Mi formulario"
    'Boton salir     --------Como se asocia el intro????????????????????????????
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    'Boton verde
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.BackColor = Color.Green
        etiqueta = "Mi formulario"
        Label1.Text = etiqueta
    End Sub
    'Boton rojo
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.BackColor = Color.Red
        Button5.Enabled = True

    End Sub
    'Boton azul
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.BackColor = Color.Blue
    End Sub
    'Boton click aqui
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        etiqueta = "Hola mundo"
        Label1.Text = etiqueta
        Button5.Enabled = False
    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
        Close()

    End Sub

End Class
