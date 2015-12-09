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
        Me.cas1 = New System.Windows.Forms.Button()
        Me.cas2 = New System.Windows.Forms.Button()
        Me.cas3 = New System.Windows.Forms.Button()
        Me.cas8 = New System.Windows.Forms.Button()
        Me.cas5 = New System.Windows.Forms.Button()
        Me.cas4 = New System.Windows.Forms.Button()
        Me.cas7 = New System.Windows.Forms.Button()
        Me.botAzul = New System.Windows.Forms.Button()
        Me.cas6 = New System.Windows.Forms.Button()
        Me.cas9 = New System.Windows.Forms.Button()
        Me.titulo = New System.Windows.Forms.Label()
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
        'cas1
        '
        Me.cas1.Location = New System.Drawing.Point(55, 212)
        Me.cas1.Name = "cas1"
        Me.cas1.Size = New System.Drawing.Size(75, 68)
        Me.cas1.TabIndex = 1
        Me.cas1.UseVisualStyleBackColor = True
        '
        'cas2
        '
        Me.cas2.Location = New System.Drawing.Point(188, 212)
        Me.cas2.Name = "cas2"
        Me.cas2.Size = New System.Drawing.Size(75, 68)
        Me.cas2.TabIndex = 2
        Me.cas2.UseVisualStyleBackColor = True
        '
        'cas3
        '
        Me.cas3.Location = New System.Drawing.Point(315, 212)
        Me.cas3.Name = "cas3"
        Me.cas3.Size = New System.Drawing.Size(75, 68)
        Me.cas3.TabIndex = 3
        Me.cas3.UseVisualStyleBackColor = True
        '
        'cas8
        '
        Me.cas8.Location = New System.Drawing.Point(188, 395)
        Me.cas8.Name = "cas8"
        Me.cas8.Size = New System.Drawing.Size(75, 64)
        Me.cas8.TabIndex = 4
        Me.cas8.UseVisualStyleBackColor = True
        '
        'cas5
        '
        Me.cas5.Location = New System.Drawing.Point(188, 302)
        Me.cas5.Name = "cas5"
        Me.cas5.Size = New System.Drawing.Size(75, 66)
        Me.cas5.TabIndex = 5
        Me.cas5.UseVisualStyleBackColor = True
        '
        'cas4
        '
        Me.cas4.Location = New System.Drawing.Point(55, 302)
        Me.cas4.Name = "cas4"
        Me.cas4.Size = New System.Drawing.Size(75, 66)
        Me.cas4.TabIndex = 6
        Me.cas4.UseVisualStyleBackColor = True
        '
        'cas7
        '
        Me.cas7.Location = New System.Drawing.Point(55, 395)
        Me.cas7.Name = "cas7"
        Me.cas7.Size = New System.Drawing.Size(75, 64)
        Me.cas7.TabIndex = 7
        Me.cas7.UseVisualStyleBackColor = True
        '
        'botAzul
        '
        Me.botAzul.BackColor = System.Drawing.Color.Blue
        Me.botAzul.Location = New System.Drawing.Point(261, 124)
        Me.botAzul.Name = "botAzul"
        Me.botAzul.Size = New System.Drawing.Size(129, 35)
        Me.botAzul.TabIndex = 8
        Me.botAzul.Text = "Jugador2"
        Me.botAzul.UseVisualStyleBackColor = False
        '
        'cas6
        '
        Me.cas6.Location = New System.Drawing.Point(315, 302)
        Me.cas6.Name = "cas6"
        Me.cas6.Size = New System.Drawing.Size(75, 66)
        Me.cas6.TabIndex = 9
        Me.cas6.UseVisualStyleBackColor = True
        '
        'cas9
        '
        Me.cas9.Location = New System.Drawing.Point(315, 395)
        Me.cas9.Name = "cas9"
        Me.cas9.Size = New System.Drawing.Size(75, 64)
        Me.cas9.TabIndex = 10
        Me.cas9.UseVisualStyleBackColor = True
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 513)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.cas9)
        Me.Controls.Add(Me.cas6)
        Me.Controls.Add(Me.botAzul)
        Me.Controls.Add(Me.cas7)
        Me.Controls.Add(Me.cas4)
        Me.Controls.Add(Me.cas5)
        Me.Controls.Add(Me.cas8)
        Me.Controls.Add(Me.cas3)
        Me.Controls.Add(Me.cas2)
        Me.Controls.Add(Me.cas1)
        Me.Controls.Add(Me.botRojo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents botRojo As Button
    Friend WithEvents cas1 As Button
    Friend WithEvents cas2 As Button
    Friend WithEvents cas3 As Button
    Friend WithEvents cas8 As Button
    Friend WithEvents cas5 As Button
    Friend WithEvents cas4 As Button
    Friend WithEvents cas7 As Button
    Friend WithEvents botAzul As Button
    Friend WithEvents cas6 As Button
    Friend WithEvents cas9 As Button
    Friend WithEvents titulo As Label
End Class
