<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.botRojo = New System.Windows.Forms.Button()
        Me.bot1 = New System.Windows.Forms.Button()
        Me.bot2 = New System.Windows.Forms.Button()
        Me.bot3 = New System.Windows.Forms.Button()
        Me.bot8 = New System.Windows.Forms.Button()
        Me.bot5 = New System.Windows.Forms.Button()
        Me.bot4 = New System.Windows.Forms.Button()
        Me.bot7 = New System.Windows.Forms.Button()
        Me.botAzul = New System.Windows.Forms.Button()
        Me.bot6 = New System.Windows.Forms.Button()
        Me.bot9 = New System.Windows.Forms.Button()
        Me.titulo = New System.Windows.Forms.Label()
        Me.botSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'botRojo
        '
        Me.botRojo.BackColor = System.Drawing.Color.Red
        Me.botRojo.Location = New System.Drawing.Point(55, 124)
        Me.botRojo.Name = "botRojo"
        Me.botRojo.Size = New System.Drawing.Size(133, 35)
        Me.botRojo.TabIndex = 0
        Me.botRojo.Text = "Jugador1"
        Me.botRojo.UseVisualStyleBackColor = False
        '
        'bot1
        '
        Me.bot1.Location = New System.Drawing.Point(71, 210)
        Me.bot1.Name = "bot1"
        Me.bot1.Size = New System.Drawing.Size(75, 68)
        Me.bot1.TabIndex = 1
        Me.bot1.UseVisualStyleBackColor = True
        '
        'bot2
        '
        Me.bot2.Location = New System.Drawing.Point(204, 210)
        Me.bot2.Name = "bot2"
        Me.bot2.Size = New System.Drawing.Size(75, 68)
        Me.bot2.TabIndex = 2
        Me.bot2.UseVisualStyleBackColor = True
        '
        'bot3
        '
        Me.bot3.Location = New System.Drawing.Point(331, 210)
        Me.bot3.Name = "bot3"
        Me.bot3.Size = New System.Drawing.Size(75, 68)
        Me.bot3.TabIndex = 3
        Me.bot3.UseVisualStyleBackColor = True
        '
        'bot8
        '
        Me.bot8.Location = New System.Drawing.Point(204, 393)
        Me.bot8.Name = "bot8"
        Me.bot8.Size = New System.Drawing.Size(75, 64)
        Me.bot8.TabIndex = 4
        Me.bot8.UseVisualStyleBackColor = True
        '
        'bot5
        '
        Me.bot5.Location = New System.Drawing.Point(204, 300)
        Me.bot5.Name = "bot5"
        Me.bot5.Size = New System.Drawing.Size(75, 66)
        Me.bot5.TabIndex = 5
        Me.bot5.UseVisualStyleBackColor = True
        '
        'bot4
        '
        Me.bot4.Location = New System.Drawing.Point(71, 300)
        Me.bot4.Name = "bot4"
        Me.bot4.Size = New System.Drawing.Size(75, 66)
        Me.bot4.TabIndex = 6
        Me.bot4.UseVisualStyleBackColor = True
        '
        'bot7
        '
        Me.bot7.Location = New System.Drawing.Point(71, 393)
        Me.bot7.Name = "bot7"
        Me.bot7.Size = New System.Drawing.Size(75, 64)
        Me.bot7.TabIndex = 7
        Me.bot7.UseVisualStyleBackColor = True
        '
        'botAzul
        '
        Me.botAzul.BackColor = System.Drawing.Color.Blue
        Me.botAzul.Location = New System.Drawing.Point(301, 124)
        Me.botAzul.Name = "botAzul"
        Me.botAzul.Size = New System.Drawing.Size(129, 35)
        Me.botAzul.TabIndex = 8
        Me.botAzul.Text = "Jugador2"
        Me.botAzul.UseVisualStyleBackColor = False
        '
        'bot6
        '
        Me.bot6.Location = New System.Drawing.Point(331, 300)
        Me.bot6.Name = "bot6"
        Me.bot6.Size = New System.Drawing.Size(75, 66)
        Me.bot6.TabIndex = 9
        Me.bot6.UseVisualStyleBackColor = True
        '
        'bot9
        '
        Me.bot9.Location = New System.Drawing.Point(331, 393)
        Me.bot9.Name = "bot9"
        Me.bot9.Size = New System.Drawing.Size(75, 64)
        Me.bot9.TabIndex = 10
        Me.bot9.UseVisualStyleBackColor = True
        '
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo.Location = New System.Drawing.Point(97, 35)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(263, 31)
        Me.titulo.TabIndex = 11
        Me.titulo.Text = "TRES  EN   RAYA"
        '
        'botSalir
        '
        Me.botSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.botSalir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.botSalir.Location = New System.Drawing.Point(188, 506)
        Me.botSalir.Name = "botSalir"
        Me.botSalir.Size = New System.Drawing.Size(75, 23)
        Me.botSalir.TabIndex = 12
        Me.botSalir.Text = "Salir"
        Me.botSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 541)
        Me.Controls.Add(Me.botSalir)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.bot9)
        Me.Controls.Add(Me.bot6)
        Me.Controls.Add(Me.botAzul)
        Me.Controls.Add(Me.bot7)
        Me.Controls.Add(Me.bot4)
        Me.Controls.Add(Me.bot5)
        Me.Controls.Add(Me.bot8)
        Me.Controls.Add(Me.bot3)
        Me.Controls.Add(Me.bot2)
        Me.Controls.Add(Me.bot1)
        Me.Controls.Add(Me.botRojo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents botRojo As Button
    Friend WithEvents bot1 As Button
    Friend WithEvents bot2 As Button
    Friend WithEvents bot3 As Button
    Friend WithEvents bot8 As Button
    Friend WithEvents bot5 As Button
    Friend WithEvents bot4 As Button
    Friend WithEvents bot7 As Button
    Friend WithEvents botAzul As Button
    Friend WithEvents bot6 As Button
    Friend WithEvents bot9 As Button
    Friend WithEvents titulo As Label
    Friend WithEvents botSalir As Button
End Class
