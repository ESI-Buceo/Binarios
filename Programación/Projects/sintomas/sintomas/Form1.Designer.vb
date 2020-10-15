<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Idiomas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContraseñaText = New System.Windows.Forms.MaskedTextBox()
        Me.UsuarioText = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Idiomas
        '
        Me.Idiomas.FormattingEnabled = True
        Me.Idiomas.Items.AddRange(New Object() {"", "Español", "Ingles", "Portugues", "Frances"})
        Me.Idiomas.Location = New System.Drawing.Point(1, 1)
        Me.Idiomas.Name = "Idiomas"
        Me.Idiomas.Size = New System.Drawing.Size(121, 21)
        Me.Idiomas.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(243, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Intoducir contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(243, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Intoducir usuario"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(246, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ContraseñaText
        '
        Me.ContraseñaText.Location = New System.Drawing.Point(246, 160)
        Me.ContraseñaText.Name = "ContraseñaText"
        Me.ContraseñaText.Size = New System.Drawing.Size(100, 20)
        Me.ContraseñaText.TabIndex = 7
        '
        'UsuarioText
        '
        Me.UsuarioText.Location = New System.Drawing.Point(246, 107)
        Me.UsuarioText.Name = "UsuarioText"
        Me.UsuarioText.Size = New System.Drawing.Size(100, 20)
        Me.UsuarioText.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 388)
        Me.Controls.Add(Me.Idiomas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ContraseñaText)
        Me.Controls.Add(Me.UsuarioText)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Idiomas As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ContraseñaText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents UsuarioText As System.Windows.Forms.MaskedTextBox
End Class
