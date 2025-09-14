<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataGridUC
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        DataGridView1 = New DataGridView()
        BtnSave = New Button()
        BtnDelete = New Button()
        Label2 = New Label()
        TBProductName = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TBPricePerUnit = New TextBox()
        Label5 = New Label()
        TBStock = New TextBox()
        Label6 = New Label()
        TBCreatedAt = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(8, 8)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(682, 280)
        DataGridView1.TabIndex = 0
        ' 
        ' BtnSave
        ' 
        BtnSave.BackColor = Color.LightGreen
        BtnSave.Location = New Point(752, 265)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(75, 23)
        BtnSave.TabIndex = 1
        BtnSave.Text = "Save"
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackColor = Color.Red
        BtnDelete.ForeColor = Color.Transparent
        BtnDelete.Location = New Point(833, 265)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(75, 23)
        BtnDelete.TabIndex = 2
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(790, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 15)
        Label2.TabIndex = 4
        Label2.Text = "Product info"
        ' 
        ' TBProductName
        ' 
        TBProductName.Location = New Point(752, 60)
        TBProductName.Name = "TBProductName"
        TBProductName.Size = New Size(156, 23)
        TBProductName.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(752, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 15)
        Label3.TabIndex = 6
        Label3.Text = "Product name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(752, 95)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 15)
        Label4.TabIndex = 8
        Label4.Text = "Price per unit"
        ' 
        ' TBPricePerUnit
        ' 
        TBPricePerUnit.Location = New Point(752, 113)
        TBPricePerUnit.Name = "TBPricePerUnit"
        TBPricePerUnit.Size = New Size(156, 23)
        TBPricePerUnit.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(752, 148)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 10
        Label5.Text = "Stock"
        ' 
        ' TBStock
        ' 
        TBStock.Location = New Point(752, 166)
        TBStock.Name = "TBStock"
        TBStock.ReadOnly = True
        TBStock.Size = New Size(156, 23)
        TBStock.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(752, 200)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 15)
        Label6.TabIndex = 12
        Label6.Text = "Created at"
        ' 
        ' TBCreatedAt
        ' 
        TBCreatedAt.Location = New Point(752, 218)
        TBCreatedAt.Name = "TBCreatedAt"
        TBCreatedAt.ReadOnly = True
        TBCreatedAt.Size = New Size(156, 23)
        TBCreatedAt.TabIndex = 11
        ' 
        ' DataGridUC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label6)
        Controls.Add(TBCreatedAt)
        Controls.Add(Label5)
        Controls.Add(TBStock)
        Controls.Add(Label4)
        Controls.Add(TBPricePerUnit)
        Controls.Add(Label3)
        Controls.Add(TBProductName)
        Controls.Add(Label2)
        Controls.Add(BtnDelete)
        Controls.Add(BtnSave)
        Controls.Add(DataGridView1)
        Name = "DataGridUC"
        Size = New Size(956, 296)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TBProductName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TBPricePerUnit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBStock As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBCreatedAt As TextBox

End Class
