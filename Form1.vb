Public Class Form1
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        ' Validação básica dos campo
        If String.IsNullOrWhiteSpace(text_login.Text) Then
            MessageBox.Show("Informe o e-mail ou usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            text_login.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(text_senha.Text) Then
            MessageBox.Show("Informe a senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            text_senha.Focus()
            Return
        End If


        sql = $"Select COUNT(1) FROM usuarios WHERE Email = '{text_login.Text}' And Password = '{text_senha.Text}'"
        rs = db.Execute(sql)
        Dim result As Integer = Convert.ToInt32(rs(0).Value)
        If result = 1 Then
            MessageBox.Show("Login efetuado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide() ' Esconder formulário de login
            Form2.Show() ' Mostrar formulário principal
        Else
            MessageBox.Show("E-mail ou senha incorretos.", "Falha no login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            text_senha.Text = ""
            text_senha.Focus()
            text_login.SelectAll()
        End If
        rs.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        text_senha.PasswordChar = "*"
    End Sub

    Private Sub btn_mostrar_senha_Click(sender As Object, e As EventArgs) Handles btn_mostrar_senha.Click
        If text_senha.PasswordChar = "" Then
            ' Ocultar senha
            text_senha.PasswordChar = "*"
            btn_mostrar_senha.Text = "👁"
        Else
            ' Mostrar senha
            text_senha.PasswordChar = ""
            btn_mostrar_senha.Text = "🙈"
    End Sub
End Class
