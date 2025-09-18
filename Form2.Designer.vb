<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Button1 = New Button()
        ImageList1 = New ImageList(components)
        ListView1 = New ListView()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.WhiteSmoke
        Button1.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(684, 37)
        Button1.Name = "Button1"
        Button1.Size = New Size(92, 72)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth8Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(12, 123)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(776, 324)
        ListView1.TabIndex = 2
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(28, 46)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 3
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ComboBox1)
        Controls.Add(ListView1)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ComboBox1 As ComboBox
End Class
