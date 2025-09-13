<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        MenuStrip1 = New MenuStrip()
        MainPageToolStripMenuItem = New ToolStripMenuItem()
        ProductToolStripMenuItem = New ToolStripMenuItem()
        CreateProductToolStripMenuItem = New ToolStripMenuItem()
        ListToolStripMenuItem = New ToolStripMenuItem()
        ClientToolStripMenuItem = New ToolStripMenuItem()
        CreateClientToolStripMenuItem1 = New ToolStripMenuItem()
        ListAllToolStripMenuItem = New ToolStripMenuItem()
        ProviderToolStripMenuItem = New ToolStripMenuItem()
        CreateProviderToolStripMenuItem2 = New ToolStripMenuItem()
        ListAllToolStripMenuItem1 = New ToolStripMenuItem()
        UserToolStripMenuItem = New ToolStripMenuItem()
        CreateUserToolStripMenuItem3 = New ToolStripMenuItem()
        ListAllToolStripMenuItem2 = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MainPageToolStripMenuItem, ProductToolStripMenuItem, ClientToolStripMenuItem, ProviderToolStripMenuItem, UserToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MainPageToolStripMenuItem
        ' 
        MainPageToolStripMenuItem.Name = "MainPageToolStripMenuItem"
        MainPageToolStripMenuItem.Size = New Size(75, 20)
        MainPageToolStripMenuItem.Text = "Main Page"
        ' 
        ' ProductToolStripMenuItem
        ' 
        ProductToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CreateProductToolStripMenuItem, ListToolStripMenuItem})
        ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        ProductToolStripMenuItem.Size = New Size(61, 20)
        ProductToolStripMenuItem.Text = "Product"
        ' 
        ' CreateProductToolStripMenuItem
        ' 
        CreateProductToolStripMenuItem.Name = "CreateProductToolStripMenuItem"
        CreateProductToolStripMenuItem.Size = New Size(180, 22)
        CreateProductToolStripMenuItem.Text = "Create"
        ' 
        ' ListToolStripMenuItem
        ' 
        ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        ListToolStripMenuItem.Size = New Size(180, 22)
        ListToolStripMenuItem.Text = "List All"
        ' 
        ' ClientToolStripMenuItem
        ' 
        ClientToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CreateClientToolStripMenuItem1, ListAllToolStripMenuItem})
        ClientToolStripMenuItem.Name = "ClientToolStripMenuItem"
        ClientToolStripMenuItem.Size = New Size(50, 20)
        ClientToolStripMenuItem.Text = "Client"
        ' 
        ' CreateClientToolStripMenuItem1
        ' 
        CreateClientToolStripMenuItem1.Name = "CreateClientToolStripMenuItem1"
        CreateClientToolStripMenuItem1.Size = New Size(180, 22)
        CreateClientToolStripMenuItem1.Text = "Create"
        ' 
        ' ListAllToolStripMenuItem
        ' 
        ListAllToolStripMenuItem.Name = "ListAllToolStripMenuItem"
        ListAllToolStripMenuItem.Size = New Size(180, 22)
        ListAllToolStripMenuItem.Text = "List All"
        ' 
        ' ProviderToolStripMenuItem
        ' 
        ProviderToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CreateProviderToolStripMenuItem2, ListAllToolStripMenuItem1})
        ProviderToolStripMenuItem.Name = "ProviderToolStripMenuItem"
        ProviderToolStripMenuItem.Size = New Size(63, 20)
        ProviderToolStripMenuItem.Text = "Provider"
        ' 
        ' CreateProviderToolStripMenuItem2
        ' 
        CreateProviderToolStripMenuItem2.Name = "CreateProviderToolStripMenuItem2"
        CreateProviderToolStripMenuItem2.Size = New Size(180, 22)
        CreateProviderToolStripMenuItem2.Text = "Create"
        ' 
        ' ListAllToolStripMenuItem1
        ' 
        ListAllToolStripMenuItem1.Name = "ListAllToolStripMenuItem1"
        ListAllToolStripMenuItem1.Size = New Size(180, 22)
        ListAllToolStripMenuItem1.Text = "List All"
        ' 
        ' UserToolStripMenuItem
        ' 
        UserToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CreateUserToolStripMenuItem3, ListAllToolStripMenuItem2})
        UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        UserToolStripMenuItem.Size = New Size(42, 20)
        UserToolStripMenuItem.Text = "User"
        ' 
        ' CreateUserToolStripMenuItem3
        ' 
        CreateUserToolStripMenuItem3.Name = "CreateUserToolStripMenuItem3"
        CreateUserToolStripMenuItem3.Size = New Size(180, 22)
        CreateUserToolStripMenuItem3.Text = "Create"
        ' 
        ' ListAllToolStripMenuItem2
        ' 
        ListAllToolStripMenuItem2.Name = "ListAllToolStripMenuItem2"
        ListAllToolStripMenuItem2.Size = New Size(180, 22)
        ListAllToolStripMenuItem2.Text = "List All"
        ' 
        ' MainPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "MainPage"
        Text = "MainPage"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MainPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateClientToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProviderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateProviderToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ListAllToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateUserToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ListAllToolStripMenuItem2 As ToolStripMenuItem
End Class
