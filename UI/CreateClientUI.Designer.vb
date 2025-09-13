<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateClientUI
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
        Label1 = New Label()
        BtnSave = New Button()
        BtnCancel = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TXTName = New TextBox()
        TXTLastname = New TextBox()
        TXTCompany = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(93, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 0
        Label1.Text = "Create Client"
        ' 
        ' BtnSave
        ' 
        BtnSave.BackColor = Color.LightGreen
        BtnSave.Location = New Point(63, 249)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(67, 29)
        BtnSave.TabIndex = 1
        BtnSave.Text = "Save"
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' BtnCancel
        ' 
        BtnCancel.Location = New Point(136, 249)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(67, 29)
        BtnCancel.TabIndex = 2
        BtnCancel.Text = "Cancel"
        BtnCancel.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(63, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 3
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(63, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 4
        Label3.Text = "Lastname"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(63, 193)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 5
        Label4.Text = "Company"
        ' 
        ' TXTName
        ' 
        TXTName.Location = New Point(63, 116)
        TXTName.Name = "TXTName"
        TXTName.Size = New Size(139, 23)
        TXTName.TabIndex = 6
        ' 
        ' TXTLastname
        ' 
        TXTLastname.Location = New Point(63, 164)
        TXTLastname.Name = "TXTLastname"
        TXTLastname.Size = New Size(139, 23)
        TXTLastname.TabIndex = 7
        ' 
        ' TXTCompany
        ' 
        TXTCompany.Location = New Point(63, 211)
        TXTCompany.Name = "TXTCompany"
        TXTCompany.Size = New Size(139, 23)
        TXTCompany.TabIndex = 8
        ' 
        ' CreateClientUI
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(266, 332)
        Controls.Add(TXTCompany)
        Controls.Add(TXTLastname)
        Controls.Add(TXTName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(BtnCancel)
        Controls.Add(BtnSave)
        Controls.Add(Label1)
        Name = "CreateClientUI"
        Text = "CreateClientUI"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTName As TextBox
    Friend WithEvents TXTLastname As TextBox
    Friend WithEvents TXTCompany As TextBox
End Class
