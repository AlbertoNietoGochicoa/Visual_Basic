Public Class Form1
    Dim turno As Integer = 1
    Dim contador As Integer
    Sub comprobarTerminado()
        If contador = 10 Then
            MsgBox("Juego terminado")
            Me.Close()
        End If
    End Sub
    Sub turnoRojo()
        'este va a ser el turno 1
        botRojo.BackColor = Color.Red
        botAzul.Enabled = False
        botAzul.BackColor = Color.Gray
        botRojo.Enabled = True
        turno = 2
        contador += 1
        comprobarTerminado()
    End Sub

    Sub turnoAzul()
        'este va a ser el turno 2
        botAzul.BackColor = Color.Blue
        botAzul.Enabled = True
        botRojo.BackColor = Color.Gray
        botRojo.Enabled = False
        turno = 1
        contador += 1
        comprobarTerminado()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        turnoRojo()


    End Sub

    Private Sub cas1_Click(sender As Object, e As EventArgs) Handles cas1.Click
        If turno = 1 Then
            cas1.BackColor = Color.Blue
            cas1.Enabled = False
            turnoRojo()
        Else
            cas1.BackColor = Color.Red
            cas1.Enabled = False
            turnoAzul()
        End If
    End Sub

    Private Sub cas2_Click(sender As Object, e As EventArgs) Handles cas2.Click
        If turno = 1 Then
            cas2.BackColor = Color.Blue
            cas2.Enabled = False
            turnoRojo()
        Else
            cas2.BackColor = Color.Red
            cas2.Enabled = False
            turnoAzul()
        End If
    End Sub

    Private Sub cas3_Click(sender As Object, e As EventArgs) Handles cas3.Click
        If turno = 1 Then
            cas3.BackColor = Color.Blue
            cas3.Enabled = False
            turnoRojo()
        Else
            cas3.BackColor = Color.Red
            cas3.Enabled = False
            turnoAzul()
        End If
    End Sub

    Private Sub cas4_Click(sender As Object, e As EventArgs) Handles cas4.Click
        If turno = 1 Then
            cas4.BackColor = Color.Blue
            cas4.Enabled = False
            turnoRojo()
        Else
            cas4.BackColor = Color.Red
            cas4.Enabled = False
            turnoAzul()
        End If
    End Sub

    Private Sub cas5_Click(sender As Object, e As EventArgs) Handles cas5.Click
        If turno = 1 Then
            cas5.BackColor = Color.Blue
            cas5.Enabled = False
            turnoRojo()
        Else
            cas5.BackColor = Color.Red
            cas5.Enabled = False
            turnoAzul()
        End If
    End Sub

    Private Sub cas6_Click(sender As Object, e As EventArgs) Handles cas6.Click
        If turno = 1 Then
            cas6.BackColor = Color.Blue
            cas6.Enabled = False
            turnoRojo()
        Else
            cas6.BackColor = Color.Red
            cas6.Enabled = False
            turnoAzul()
        End If
    End Sub

    Private Sub cas7_Click(sender As Object, e As EventArgs) Handles cas7.Click
        If turno = 1 Then
            cas7.BackColor = Color.Blue
            cas7.Enabled = False
            turnoRojo()
        Else
            cas7.BackColor = Color.Red
            cas7.Enabled = False
            turnoAzul()
        End If
    End Sub

    Private Sub cas8_Click(sender As Object, e As EventArgs) Handles cas8.Click
        If turno = 1 Then
            cas8.BackColor = Color.Blue
            cas8.Enabled = False
            turnoRojo()
        Else
            cas8.BackColor = Color.Red
            cas8.Enabled = False
            turnoAzul()
        End If
    End Sub

    Private Sub cas9_Click(sender As Object, e As EventArgs) Handles cas9.Click
        If turno = 1 Then
            cas9.BackColor = Color.Blue
            cas9.Enabled = False
            turnoRojo()
        Else
            cas9.BackColor = Color.Red
            cas9.Enabled = False
            turnoAzul()
        End If
    End Sub
End Class
