Module ConexionBase
    Public Conexion As OleDb.OleDbConnection

    Public Sub AbrirConexion()
        Try
            Conexion = New OleDb.OleDbConnection
            Dim CadenaConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Caballeros Diego\Documents\ClasesU\PruebaAccess\EjemploProyecto.accdb"
            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()
        Catch ex As Exception
            MsgBox("Error en la conexion a la base de datos")

        End Try
    End Sub


    Public Function Consulta(cadenaOperacion As String) As DataSet
        AbrirConexion()

        Dim da As New OleDb.OleDbDataAdapter(cadenaOperacion, Conexion)
        Dim ds As New DataSet
        da.Fill(ds)

        If Conexion.State Then
            Conexion.Close()
        End If

        Return ds
    End Function

    Public Sub Accion(cadena As String)
        AbrirConexion()
        Dim da As New OleDb.OleDbCommand(cadena, Conexion)

        da.ExecuteNonQuery()

        If Conexion.State Then
            Conexion.Close()
        End If
    End Sub

End Module
