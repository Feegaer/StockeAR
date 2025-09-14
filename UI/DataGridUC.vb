Imports Microsoft.Data.SqlClient

Public Class DataGridUC
    Inherits UserControl

    Public Property ChoosedTable As String
    Public Sub DataGridUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(ChoosedTable) Then
            LoadData()
        End If
    End Sub

    Private Sub LoadData()
        Using conn As SqlConnection = Database.Connect("StockeAR")
            conn.Open()

            Dim query As String = $"SELECT * FROM {ChoosedTable}"
            Using cmd As New SqlCommand(query, conn)
                Using adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DataGridView1.DataSource = table
                End Using
            End Using
        End Using
    End Sub
End Class
