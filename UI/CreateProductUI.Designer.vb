<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateProductUI
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
        BtnSave = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TxtProductName = New TextBox()
        TxtPricePerUnit = New TextBox()
        TxtStock = New TextBox()
        BtnCancel = New Button()
        SuspendLayout()
        ' 
        ' BtnSave
        ' 
        BtnSave.BackColor = Color.PaleGreen
        BtnSave.Location = New Point(77, 276)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(73, 23)
        BtnSave.TabIndex = 0
        BtnSave.Text = "Save"
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(77, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 15)
        Label1.TabIndex = 1
        Label1.Text = "Create Product"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(77, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 2
        Label2.Text = "Product Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(78, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 15)
        Label3.TabIndex = 3
        Label3.Text = "Price per unit"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(78, 216)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 4
        Label4.Text = "Stock"
        ' 
        ' TxtProductName
        ' 
        TxtProductName.CharacterCasing = CharacterCasing.Upper
        TxtProductName.Location = New Point(78, 127)
        TxtProductName.Name = "TxtProductName"
        TxtProductName.Size = New Size(152, 23)
        TxtProductName.TabIndex = 5
        ' 
        ' TxtPricePerUnit
        ' 
        TxtPricePerUnit.CharacterCasing = CharacterCasing.Upper
        TxtPricePerUnit.Location = New Point(78, 181)
        TxtPricePerUnit.Name = "TxtPricePerUnit"
        TxtPricePerUnit.Size = New Size(152, 23)
        TxtPricePerUnit.TabIndex = 6
        ' 
        ' TxtStock
        ' 
        TxtStock.Location = New Point(78, 234)
        TxtStock.Name = "TxtStock"
        TxtStock.Size = New Size(152, 23)
        TxtStock.TabIndex = 7
        ' 
        ' BtnCancel
        ' 
        BtnCancel.BackColor = Color.Transparent
        BtnCancel.FlatAppearance.BorderColor = Color.Silver
        BtnCancel.Location = New Point(157, 276)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(73, 23)
        BtnCancel.TabIndex = 8
        BtnCancel.Text = "Cancel"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' CreateProductUI
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(307, 372)
        Controls.Add(BtnCancel)
        Controls.Add(TxtStock)
        Controls.Add(TxtPricePerUnit)
        Controls.Add(TxtProductName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnSave)
        Name = "CreateProductUI"
        Text = "CreateProductUI"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents TxtProductName As TextBox
    Friend WithEvents TxtPricePerUnit As TextBox
    Friend WithEvents TxtStock As TextBox
End Class
