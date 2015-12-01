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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.backgroundButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.showButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackgroundImage = CType(resources.GetObject("TableLayoutPanel1.BackgroundImage"), System.Drawing.Image)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(201, 78)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(418, 268)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TableLayoutPanel1.SetColumnSpan(Me.PictureBox1, 2)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(412, 128)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox1.Location = New System.Drawing.Point(3, 137)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(203, 128)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "strech"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackgroundImage = CType(resources.GetObject("FlowLayoutPanel1.BackgroundImage"), System.Drawing.Image)
        Me.FlowLayoutPanel1.Controls.Add(Me.closeButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.backgroundButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.clearButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.showButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(212, 137)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(203, 128)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'closeButton
        '
        Me.closeButton.AutoSize = True
        Me.closeButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.closeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.closeButton.Location = New System.Drawing.Point(3, 3)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(139, 25)
        Me.closeButton.TabIndex = 0
        Me.closeButton.Text = "cerrar"
        Me.closeButton.UseVisualStyleBackColor = False
        '
        'backgroundButton
        '
        Me.backgroundButton.AutoSize = True
        Me.backgroundButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.backgroundButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backgroundButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.backgroundButton.Location = New System.Drawing.Point(3, 34)
        Me.backgroundButton.Name = "backgroundButton"
        Me.backgroundButton.Size = New System.Drawing.Size(139, 25)
        Me.backgroundButton.TabIndex = 1
        Me.backgroundButton.Text = "establecer color de fondo"
        Me.backgroundButton.UseVisualStyleBackColor = False
        '
        'clearButton
        '
        Me.clearButton.AutoSize = True
        Me.clearButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.clearButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clearButton.Location = New System.Drawing.Point(3, 65)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(139, 25)
        Me.clearButton.TabIndex = 2
        Me.clearButton.Text = "borrar la imagen"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'showButton
        '
        Me.showButton.AutoSize = True
        Me.showButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.showButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.showButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.showButton.Location = New System.Drawing.Point(3, 96)
        Me.showButton.Name = "showButton"
        Me.showButton.Size = New System.Drawing.Size(139, 25)
        Me.showButton.TabIndex = 3
        Me.showButton.Text = "mostrar imagen"
        Me.showButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(825, 415)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "mostrar una imagen"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents closeButton As Button
    Friend WithEvents backgroundButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents showButton As Button
End Class
