<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Label1 = New Label()
        Button1 = New Button()
        tb_username = New TextBox()
        tb_password = New TextBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 0
        Label1.Text = "Usuario"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(62, 179)
        Button1.Name = "Button1"
        Button1.Size = New Size(180, 32)
        Button1.TabIndex = 1
        Button1.Text = "Ingresar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' tb_username
        ' 
        tb_username.Location = New Point(62, 80)
        tb_username.Name = "tb_username"
        tb_username.Size = New Size(180, 23)
        tb_username.TabIndex = 2
        ' 
        ' tb_password
        ' 
        tb_password.Location = New Point(62, 135)
        tb_password.Name = "tb_password"
        tb_password.Size = New Size(180, 23)
        tb_password.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(64, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 4
        Label2.Text = "Contraseña"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(307, 269)
        Controls.Add(Label2)
        Controls.Add(tb_password)
        Controls.Add(tb_username)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Login"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents tb_username As TextBox
    Friend WithEvents tb_password As TextBox
    Friend WithEvents Label2 As Label

End Class
