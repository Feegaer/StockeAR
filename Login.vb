Imports Microsoft.Data.SqlClient
Imports StockeAR.Database
Imports System.Data.SqlClient
Public Class Login
    Private Property Username As String = ""
    Private Property Password As String = ""
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tb_username.TextChanged
        Username = tb_username.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tb_password.TextChanged
        Password = tb_password.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using conn As SqlConnection = Database.Connect("DBUsers")
                conn.Open()
                Dim query As String = "SELECT COUNT(1) FROM _user WHERE username=@username AND password=@password"
                Using cmd As New SqlCommand(query, conn)
                    ' Use parameterized query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@username", Username)
                    cmd.Parameters.AddWithValue("@password", Password)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar()) ' 0 = fail, 1 = successfull

                    If count > 0 Then
                        Dim mainForm As New MainPage() ' MainPage Form instance
                        mainForm.Show() ' Show the MainPage form
                        Me.Hide() ' Hide the Login form
                        AddHandler mainForm.FormClosed, Sub(s, args) Me.Close() ' Closes app when the main form is closed
                    Else
                        MessageBox.Show("Login Failed")
                    End If

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while login: " & ex.Message)
        End Try
    End Sub
End Class
