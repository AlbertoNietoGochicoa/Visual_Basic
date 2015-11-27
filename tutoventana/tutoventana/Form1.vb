Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox1.CheckedChanged

    End Sub

    Private Sub showButton_Click(sender As Object, e As EventArgs) Handles showButton.Click

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub backGroungButton_Click(sender As Object, e As EventArgs) Handles backGroungButton.Click

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click

    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class
