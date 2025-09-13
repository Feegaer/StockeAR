Public Class MainPage
    Private Sub CreateProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateProductToolStripMenuItem.Click
        Dim FormCreateProduct As New CreateProductUI()
        FormCreateProduct.ShowDialog()
    End Sub

    Private Sub CreateClientToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CreateClientToolStripMenuItem1.Click
        Dim FormCreateClient As New CreateClientUI()
        FormCreateClient.ShowDialog()
    End Sub

    Private Sub CreateProviderToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CreateProviderToolStripMenuItem2.Click
        Dim FormCreateProvider As New CreateProviderUI()
        FormCreateProvider.ShowDialog()
    End Sub

    Private Sub CreateUserToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CreateUserToolStripMenuItem3.Click
        Dim FormCreateUser As New CreateUserUI()
        FormCreateUser.ShowDialog()
    End Sub
End Class