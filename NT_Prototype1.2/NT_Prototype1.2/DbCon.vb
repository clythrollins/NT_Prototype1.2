Imports System.Data.OleDb
Module DbCon
    Public Sql As String
    Public Cmd As OleDbCommand
    Public DataRead As OleDbDataReader
    Public Con As OleDbConnection
    Public ConStr As String = Environment.CurrentDirectory.ToString & "C:\Users\ASUS\Desktop\NT_Prototype1.2\NTPrototype1.2.accdb"

    Public Sub ConnectDb()
        Try
            Con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & ConStr & "")
            Con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module