Imports System.Data.SQLite

Class SQLiteDatabase
    Private dbConnection As [String]

    ''' <summary>
    '''     Default Constructor for SQLiteDatabase Class.
    ''' </summary>
    Public Sub New()
        dbConnection = "Data Source= " & Launcher.Current & "\YGOPRO\cards.cdb"
    End Sub

    ''' <summary>
    '''     Single Param Constructor for specifying the DB file.
    ''' </summary>
    ''' <param name="inputFile">The File containing the DB</param>
    Public Sub New(inputFile As [String])
        dbConnection = [String].Format("Data Source={0}", inputFile)
    End Sub

    ''' <summary>
    '''     Single Param Constructor for specifying advanced connection options.
    ''' </summary>
    ''' <param name="connectionOpts">A dictionary containing all desired options and their values</param>
    Public Sub New(connectionOpts As Dictionary(Of [String], [String]))
        Dim str As [String] = ""
        For Each row As KeyValuePair(Of [String], [String]) In connectionOpts
            str += [String].Format("{0}={1}; ", row.Key, row.Value)
        Next
        str = str.Trim().Substring(0, str.Length - 1)
        dbConnection = str
    End Sub

    ''' <summary>
    '''     Allows the programmer to run a query against the Database.
    ''' </summary>
    ''' <param name="sql">The SQL to run</param>
    ''' <returns>A DataTable containing the result set.</returns>
    Public Function GetDataTable(sql As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim cnn As New SQLiteConnection(dbConnection)
            cnn.Open()
            Dim mycommand As New SQLiteCommand(cnn)
            mycommand.CommandText = sql
            Dim reader As SQLiteDataReader = mycommand.ExecuteReader()
            dt.Load(reader)
            reader.Close()
            cnn.Close()
        Catch e As Exception
            Throw New Exception(e.Message)
        End Try
        Return dt
    End Function

    ''' <summary>
    '''     Allows the programmer to interact with the database for purposes other than a query.
    ''' </summary>
    ''' <param name="sql">The SQL to be run.</param>
    ''' <returns>An Integer containing the number of rows updated.</returns>
    Public Function ExecuteNonQuery(sql As String) As Integer
        Dim cnn As New SQLiteConnection(dbConnection)
        cnn.Open()
        Dim mycommand As New SQLiteCommand(cnn)
        mycommand.CommandText = sql
        Dim rowsUpdated As Integer = mycommand.ExecuteNonQuery()
        cnn.Close()
        Return rowsUpdated
    End Function

    ''' <summary>
    '''     Allows the programmer to retrieve single items from the DB.
    ''' </summary>
    ''' <param name="sql">The query to run.</param>
    ''' <returns>A string.</returns>
    Public Function ExecuteScalar(sql As String) As String
        Dim cnn As New SQLiteConnection(dbConnection)
        cnn.Open()
        Dim mycommand As New SQLiteCommand(cnn)
        mycommand.CommandText = sql
        Dim value As Object = mycommand.ExecuteScalar()
        cnn.Close()
        If value IsNot Nothing Then
            Return value.ToString()
        End If
        Return ""
    End Function

    ''' <summary>
    '''     Allows the programmer to easily update rows in the DB.
    ''' </summary>
    ''' <param name="tableName">The table to update.</param>
    ''' <param name="data">A dictionary containing Column names and their new values.</param>
    ''' <param name="where">The where clause for the update statement.</param>
    ''' <returns>A boolean true or false to signify success or failure.</returns>
    Public Function Update(tableName As [String], data As Dictionary(Of [String], [String]), where As [String]) As Boolean
        Dim vals As [String] = ""
        Dim returnCode As [Boolean] = True
        If data.Count >= 1 Then
            For Each val As KeyValuePair(Of [String], [String]) In data
                vals += [String].Format(" {0} = '{1}',", val.Key.ToString(), val.Value.ToString())
            Next
            vals = vals.Substring(0, vals.Length - 1)
        End If
        Try
            Me.ExecuteNonQuery([String].Format("update {0} set {1} where {2};", tableName, vals, where))
        Catch
            returnCode = False
        End Try
        Return returnCode
    End Function

    ''' <summary>
    '''     Allows the programmer to easily delete rows from the DB.
    ''' </summary>
    ''' <param name="tableName">The table from which to delete.</param>
    ''' <param name="where">The where clause for the delete.</param>
    ''' <returns>A boolean true or false to signify success or failure.</returns>
    Public Function Delete(tableName As [String], where As [String]) As Boolean
        Dim returnCode As [Boolean] = True
        Try
            Me.ExecuteNonQuery([String].Format("delete from {0} where {1};", tableName, where))
        Catch
            returnCode = False
        End Try
        Return returnCode
    End Function

    ''' <summary>
    '''     Allows the programmer to easily insert into the DB
    ''' </summary>
    ''' <param name="tableName">The table into which we insert the data.</param>
    ''' <param name="data">A dictionary containing the column names and data for the insert.</param>
    ''' <returns>A boolean true or false to signify success or failure.</returns>
    Public Function Insert(tableName As [String], data As Dictionary(Of [String], [String])) As Boolean
        Dim columns As [String] = ""
        Dim values As [String] = ""
        Dim returnCode As [Boolean] = True
        For Each val As KeyValuePair(Of [String], [String]) In data
            columns += [String].Format(" {0},", val.Key.ToString())
            values += [String].Format(" '{0}',", val.Value)
        Next
        columns = columns.Substring(0, columns.Length - 1)
        values = values.Substring(0, values.Length - 1)
        Try
            Me.ExecuteNonQuery([String].Format("insert into {0}({1}) values({2});", tableName, columns, values))
        Catch ex As Exception
            returnCode = False
        End Try
        Return returnCode
    End Function

    ''' <summary>
    '''     Allows the programmer to easily delete all data from the DB.
    ''' </summary>
    ''' <returns>A boolean true or false to signify success or failure.</returns>
    Public Function ClearDB() As Boolean
        Dim tables As DataTable
        Try
            tables = Me.GetDataTable("select NAME from SQLITE_MASTER where type='table' order by NAME;")
            For Each table As DataRow In tables.Rows
                Me.ClearTable(table("NAME").ToString())
            Next
            Return True
        Catch
            Return False
        End Try
    End Function

    ''' <summary>
    '''     Allows the user to easily clear all data from a specific table.
    ''' </summary>
    ''' <param name="table">The name of the table to clear.</param>
    ''' <returns>A boolean true or false to signify success or failure.</returns>
    Public Function ClearTable(table As [String]) As Boolean
        Try

            Me.ExecuteNonQuery([String].Format("delete from {0};", table))
            Return True
        Catch
            Return False
        End Try
    End Function
End Class
