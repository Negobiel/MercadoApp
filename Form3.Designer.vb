<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ListView1 = New ListView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        CheckBox1 = New CheckBox()
        Label2 = New Label()
        VScrollBar1 = New VScrollBar()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(12, 12)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(761, 276)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(481, 333)
        Button1.Name = "Button1"
        Button1.Size = New Size(256, 75)
        Button1.TabIndex = 1
        Button1.Text = "EFETUAR PAGAMENTO"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(35, 333)
        Button2.Name = "Button2"
        Button2.Size = New Size(132, 41)
        Button2.TabIndex = 2
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(35, 380)
        Button3.Name = "Button3"
        Button3.Size = New Size(132, 41)
        Button3.TabIndex = 3
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(235, 359)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 4
        Label1.Text = "TOTAL:"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(12, 294)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 19)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "Selecionar tudo"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(293, 359)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 7
        Label2.Text = "Label2"
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.Location = New Point(776, 12)
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.Size = New Size(15, 276)
        VScrollBar1.TabIndex = 8
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(VScrollBar1)
        Controls.Add(Label2)
        Controls.Add(CheckBox1)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListView1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents VScrollBar1 As VScrollBar
End Class
