Public Class Form1
    Private Sub btnContador_Click(sender As Object, e As EventArgs) Handles btnContador.Click
        ' Procedimiento -> no devuelve nada, sol ejecuta
        EjemploFor()

        ' Metodo -> devuelve siempre algo
        Math.Max(5, 10)
    End Sub


    Public Sub EjemploFor()
        ' QUE ME IMPRIMA LOS NUMEROS PARES DEL 1 - 100
        For numero As Integer = 1 To 5
            If (numero Mod 2) = 0 Then
                lbContador.Items.Add("Par: " & numero)
            Else
                lbContador.Items.Add("Impar: " & numero)
            End If
        Next
        'For contador As Decimal = 2 To 1 Step -0.25
        '    lbContador.Items.Add("Valor: " & contador)
        'Next
    End Sub



    Private Sub btnWhile_Click(sender As Object, e As EventArgs) Handles btnWhile.Click

        Dim index As Integer = 0

        'While index < 10
        '    lbxWhile.Items.Add(index)
        '    index += 1
        'End While

        While index < 1000000
            index += 1

            ' Condicion especial en el rango de 5 a 8
            If index >= 5 And index <= 8 Then
                Continue While
            End If

            ' Imprimir en el listbox
            lbxWhile.Items.Add(index)

            If index = 10 Then
                Exit While
            End If
        End While

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim index As Integer = 0

        Do
            ' Imprimir en el listbox
            lbxDoWhile.Items.Add(index)
            index += 1
        Loop While index > 10

    End Sub
End Class
