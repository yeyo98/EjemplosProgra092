Public Class Administrador
    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datos As DataSet = Consulta("SELECT * FROM Usuario")

        If datos.Tables(0).Rows.Count Then
            DataGridView1.DataSource = datos.Tables(0)
        Else
            DataGridView1.DataSource = Nothing
        End If
    End Sub
End Class