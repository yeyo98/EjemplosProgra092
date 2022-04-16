Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'ProcedimientoSuma()

        'Dim calculo As Integer = FuncionSuma()
        'ListBox1.Items.Add(calculo)

        'ProcParamSuma(TextBox1.Text, TextBox2.Text)

        Dim calculo As Integer = FuncParamSuma(TextBox1.Text, TextBox2.Text)
        ListBox1.Items.Add(calculo)

    End Sub


    ' Procedimiento
    Public Sub ProcedimientoSuma()
        Dim numero1 As Integer = TextBox1.Text
        Dim numero2 As Integer = TextBox2.Text

        Dim resultado As Integer = numero1 + numero2

        ListBox1.Items.Add(resultado)
    End Sub


    ' Procedimiento con Parametros
    Public Sub ProcParamSuma(numero1 As Integer, numero2 As Integer)
        Dim resultado As Integer = numero1 + numero2
        ListBox1.Items.Add(resultado)
    End Sub


    ' Funcion basico
    Public Function FuncionSuma() As Integer
        Dim numero1 As Integer = TextBox1.Text
        Dim numero2 As Integer = TextBox2.Text
        Dim resultado As Integer = numero1 + numero2

        Return resultado
    End Function

    ' Funcion con parametros
    Public Function FuncParamSuma(numero1 As Integer, numero2 As Integer) As Integer
        Dim resultado As Integer = numero1 + numero2
        Return resultado
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form2 As New EjemploNuevo
        form2.Show()
        Me.Hide()
    End Sub
End Class
