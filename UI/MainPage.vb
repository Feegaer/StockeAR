Public Class MainPage
    Private Sub CreateProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateProductToolStripMenuItem.Click
        Dim FormCreateProduct As New CreateProductUI() ' Creates an instance from UI Object (form)
        FormCreateProduct.ShowDialog() ' Shows the form UI to create a new product
    End Sub
    Private Sub ListProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListProductsToolStripMenuItem.Click
        Dim UCListProducts As New DataGridUC() With { ' With enables the access to object properties
            .Dock = DockStyle.Fill, ' Fills with the User Control
            .ChoosedTable = "product" ' Parameter to choose the table where data will be retrieved
        }
        PanelMainPageContainer.Controls.Clear() ' Clears Panel Container
        PanelMainPageContainer.Controls.Add(UCListProducts) ' Add the User Control to Panel Container
    End Sub
    Private Sub CreateClientToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CreateClientToolStripMenuItem1.Click
        Dim FormCreateClient As New CreateClientUI() ' Creates an instance from UI Object (form)
        FormCreateClient.ShowDialog() ' Shows the form UI to create a new client
    End Sub
    Private Sub CreateProviderToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CreateProviderToolStripMenuItem2.Click
        Dim FormCreateProvider As New CreateProviderUI() ' Creates an instance from UI Object (form)
        FormCreateProvider.ShowDialog() ' Shows the form UI to create a new provider
    End Sub
    Private Sub CreateUserToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CreateUserToolStripMenuItem3.Click
        Dim FormCreateUser As New CreateUserUI() ' Creates an instance from UI Object (form)
        FormCreateUser.ShowDialog() ' Shows the form UI to create a new user
    End Sub
    Private Sub MainPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainPageToolStripMenuItem.Click
        Dim UCMainPage As New MainPageUC() With { ' With enables the access to object properties
            .Dock = DockStyle.Fill ' Fills with the User Control
        }
        PanelMainPageContainer.Controls.Clear() ' Clears Panel Container
        PanelMainPageContainer.Controls.Add(UCMainPage) ' Add the User Control to Panel Container
    End Sub
End Class