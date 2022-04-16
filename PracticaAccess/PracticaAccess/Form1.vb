Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
    End Sub

    Public Sub CargarTabla()
        Dim datos As DataSet = Consulta("SELECT * FROM Producto")

        If datos.Tables(0).Rows.Count Then
            DataGridView1.DataSource = datos.Tables(0)
        Else
            DataGridView1.DataSource = Nothing
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CargarTabla()
    End Sub
End Class
