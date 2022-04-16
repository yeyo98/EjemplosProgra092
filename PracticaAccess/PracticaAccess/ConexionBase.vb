Module ConexionBase
    Public Conexion As OleDb.OleDbConnection

    Public Sub AbrirConexion()
        Try
            Conexion = New OleDb.OleDbConnection
            Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Caballeros Diego\Documents\ClasesU\PruebaAccess\TablaRelacional.accdb"
            Conexion.Open()
        Catch ex As Exception
            MsgBox("Error en la conexion a la base de datos")

        End Try
    End Sub


    Public Function Consulta(cadena As String) As DataSet
        Dim da As New OleDb.OleDbDataAdapter(cadena, Conexion)
        Dim ds As New DataSet
        da.Fill(ds)

        Return ds
    End Function
End Module
