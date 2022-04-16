Public Class Form1
    ' VARIABLES GLOBALES
    Dim listaCompras(5) As String
    Dim index As Integer = 0

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        ' Verificacion de que no nos pasemos del indice del arreglo
        ' indiceArreglo < index
        If (listaCompras.Length - 1) < index Then
            Return
        End If

        ' Almaceno mi nuevo valor
        listaCompras(index) = txtItem.Text
        index += 1

        txtItem.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For i As Integer = 0 To (listaCompras.Length - 1)
            lsbListaCompras.Items.Add(listaCompras(i))
        Next
    End Sub
End Class
