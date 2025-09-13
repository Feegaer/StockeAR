Imports Microsoft.Data.SqlClient

Public Class CreateClientUI
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim Name As String = Trim(TXTName.Text)
        Dim Lastname As String = Trim(TXTLastname.Text)
        Dim Company As String = Trim(TXTCompany.Text)

        If String.IsNullOrEmpty(Name) Or String.IsNullOrEmpty(Lastname) Or String.IsNullOrEmpty(Company) Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As SqlConnection = Database.Connect("StockeAR")
                conn.Open()

                Dim query As String = "INSERT INTO client(name, lastname, company) VALUES(@name, @lastname, @company)"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", Name)
                    cmd.Parameters.AddWithValue("@lastname", Lastname)
                    cmd.Parameters.AddWithValue("@company", Company)

                    Dim affectedRows As Integer = cmd.ExecuteNonQuery()

                    If affectedRows > 0 Then
                        Dim Result As DialogResult = MessageBox.Show(
                        "Client created successfully. Do you want to create another one?",
                        "Confirm action",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)

                        If Result = DialogResult.No Then
                            Me.Close()
                        Else
                            TXTName.Text = ""
                            TXTLastname.Text = ""
                            TXTCompany.Text = ""
                        End If

                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("There was an error trying to create the new client, please try again later. Error:", ex.Message)
        End Try

    End Sub
End Class