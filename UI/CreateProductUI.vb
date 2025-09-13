Imports Microsoft.Data.SqlClient

Public Class CreateProductUI
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim ProductName As String = Trim(TxtProductName.Text)
        Dim PricePerUnit As String = Trim(TxtPricePerUnit.Text)
        Dim Stock As String = Trim(TxtStock.Text)

        If (String.IsNullOrEmpty(ProductName) Or String.IsNullOrEmpty(PricePerUnit) Or String.IsNullOrEmpty(Stock)) Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If Not IsNumeric(PricePerUnit) Or Not IsNumeric(Stock) Then
            MessageBox.Show("Price per unit and Stock must be numeric values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using conn As SqlConnection = Database.Connect("StockeAR")
            conn.Open()

            Dim query As String = "INSERT INTO product(name, price_per_unit, stock) VALUES (@name, @price_per_unit, @stock)"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", ProductName)
                cmd.Parameters.AddWithValue("@price_per_unit", PricePerUnit)
                cmd.Parameters.AddWithValue("@stock", Stock)

                Dim affectedRows As Integer = cmd.ExecuteNonQuery()

                If affectedRows > 0 Then
                    Dim Result As DialogResult = MessageBox.Show(
                        "Product created successfully. Do you want to create another one?",
                        "Confirm action",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)

                    If Result = DialogResult.No Then
                        Me.Close()
                    Else
                        TxtPricePerUnit.Text = ""
                        TxtProductName.Text = ""
                        TxtStock.Text = ""
                    End If
                End If

            End Using
        End Using

    End Sub

End Class