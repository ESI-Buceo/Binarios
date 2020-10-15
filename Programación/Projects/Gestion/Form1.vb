Public Class Form1

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles UsuarioText.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles ContraseñaText.MaskInputRejected

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim usuario, usuariop, contrap, contra As String
        usuario = UsuarioText.Text
        contra = ContraseñaText.Text
        UsuarioText.Text = usuario
        ContraseñaText.Text = contra

        usuariop = "pepe"
        contrap = "1234"

        If (UsuarioText.Text = "" And Not ContraseñaText.Text = "") Then
            MessageBox.Show("ingresa el usuario", "error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            UsuarioText.Focus()

        ElseIf (Not UsuarioText.Text = "" And ContraseñaText.Text = "") Then
            MessageBox.Show("ingrese su contraseña", "error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            UsuarioText.Focus()

        ElseIf (UsuarioText.Text = "" And ContraseñaText.Text = "") Then
            MessageBox.Show("debes llenar los campos", "error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            UsuarioText.Focus()

        

        ElseIf UsuarioText.Text = usuariop And ContraseñaText.Text = contrap Then
            Form2.Show()
            Me.Hide()
        



        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
