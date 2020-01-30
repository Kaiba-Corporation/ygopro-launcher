Imports System.Data
Imports System.Collections.Generic
Imports System.Data.SQLite
Imports System.Windows.Forms

Public NotInheritable Class DatabaseHelper
    Public Shared Function CreateCommand(statement As String, connection As SQLiteConnection) As SQLiteCommand
        Return New SQLiteCommand() With {.CommandText = statement, .CommandType = CommandType.Text, .Connection = connection}
    End Function

    Public Shared Function ExecuteNonCommand(command As SQLiteCommand) As Boolean
        Try
            command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function ExecuteStringCommand(command As SQLiteCommand, columncount As Integer) As List(Of String())
        Try
            Dim values = New List(Of String())()
            Dim reader As SQLiteDataReader = command.ExecuteReader()
            While reader.Read()
                Dim row = New List(Of String)()
                For i As Integer = 0 To reader.FieldCount - 1
                    row.Add(reader(i).ToString())
                Next
                values.Add(row.ToArray())
            End While
            reader.Close()

            Return values
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return New List(Of String())()
        End Try
    End Function

    Public Shared Function ExecuteIntCommand(command As SQLiteCommand) As Integer
        Try
            Return Convert.ToInt32(command.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return -1
        End Try
    End Function
End Class