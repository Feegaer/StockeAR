Imports System.Configuration
Imports Microsoft.Data.SqlClient

Public Class Database
    Public Shared Function Connect(choosedDB As String) As SqlConnection
        Dim connectionString As String = ConfigurationManager.ConnectionStrings(choosedDB).ConnectionString
        Return New SqlConnection(connectionString)
    End Function
End Class
