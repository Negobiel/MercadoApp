<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lb_superLogin = New Label()
        lb_nome = New Label()
        lb_senha = New Label()
        text_login = New TextBox()
        text_senha = New TextBox()
        btn_login = New Button()
        btn_cadastro = New Button()
        btn_esqueci = New Button()
        btn_mostrar_senha = New Button()
        SuspendLayout()
        ' 
        ' lb_superLogin
        ' 
        lb_superLogin.AutoSize = True
        lb_superLogin.Font = New Font("Segoe UI", 20.0F, FontStyle.Regular, GraphicsUnit.Point)
        lb_superLogin.Location = New Point(334, 62)
        lb_superLogin.Name = "lb_superLogin"
        lb_superLogin.Size = New Size(84, 37)
        lb_superLogin.TabIndex = 0
        lb_superLogin.Text = "Login"
        ' 
        ' lb_nome
        ' 
        lb_nome.AutoSize = True
        lb_nome.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        lb_nome.Location = New Point(283, 123)
        lb_nome.Name = "lb_nome"
        lb_nome.Size = New Size(41, 19)
        lb_nome.TabIndex = 1
        lb_nome.Text = "Email"
        ' 
        ' lb_senha
        ' 
        lb_senha.AutoSize = True
        lb_senha.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        lb_senha.Location = New Point(283, 171)
        lb_senha.Name = "lb_senha"
        lb_senha.Size = New Size(46, 19)
        lb_senha.TabIndex = 2
        lb_senha.Text = "Senha"
        ' 
        ' text_login
        ' 
        text_login.Location = New Point(283, 145)
        text_login.Name = "text_login"
        text_login.Size = New Size(202, 23)
        text_login.TabIndex = 3
        ' 
        ' text_senha
        ' 
        text_senha.Location = New Point(283, 193)
        text_senha.Name = "text_senha"
        text_senha.Size = New Size(202, 23)
        text_senha.TabIndex = 4
        ' 
        ' btn_login
        ' 
        btn_login.Location = New Point(318, 234)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(126, 23)
        btn_login.TabIndex = 5
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' btn_cadastro
        ' 
        btn_cadastro.Location = New Point(318, 277)
        btn_cadastro.Name = "btn_cadastro"
        btn_cadastro.Size = New Size(126, 23)
        btn_cadastro.TabIndex = 6
        btn_cadastro.Text = "Cadastro"
        btn_cadastro.UseVisualStyleBackColor = True
        ' 
        ' btn_esqueci
        ' 
        btn_esqueci.Location = New Point(293, 339)
        btn_esqueci.Name = "btn_esqueci"
        btn_esqueci.Size = New Size(179, 22)
        btn_esqueci.TabIndex = 7
        btn_esqueci.Text = "Esqueci a senha"
        btn_esqueci.UseVisualStyleBackColor = True
        ' 
        ' btn_mostrar_senha
        ' 
        btn_mostrar_senha.BackColor = Color.Transparent
        btn_mostrar_senha.Location = New Point(467, 193)
        btn_mostrar_senha.Name = "btn_mostrar_senha"
        btn_mostrar_senha.Size = New Size(18, 23)
        btn_mostrar_senha.TabIndex = 8
        btn_mostrar_senha.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btn_mostrar_senha)
        Controls.Add(btn_esqueci)
        Controls.Add(btn_cadastro)
        Controls.Add(btn_login)
        Controls.Add(text_senha)
        Controls.Add(text_login)
        Controls.Add(lb_senha)
        Controls.Add(lb_nome)
        Controls.Add(lb_superLogin)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lb_superLogin As Label
    Friend WithEvents lb_nome As Label
    Friend WithEvents lb_senha As Label
    Friend WithEvents text_login As TextBox
    Friend WithEvents text_senha As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_cadastro As Button
    Friend WithEvents btn_esqueci As Button
    Friend WithEvents btn_mostrar_senha As Button
End Class
