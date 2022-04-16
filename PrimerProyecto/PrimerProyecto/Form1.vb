Public Class Form1

    ' VARIABLE GLOBAL
    Dim varGlobal As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyPrimeraVariable As String = "Diego"
        Dim MiApellido As String = "Caballeros"

        tb1.Text = MyPrimeraVariable
        TextBox2.Text = MiApellido
    End Sub

    Private Sub btn_Local_Click(sender As Object, e As EventArgs) Handles btn_Local.Click
        Dim varLocal As Integer = 0

        varLocal = varLocal + 1
        TextBox1.Text = varLocal

    End Sub

    Private Sub btn_global_Click(sender As Object, e As EventArgs) Handles btn_global.Click
        varGlobal = varGlobal + 1
        TextBox1.Text = varGlobal
    End Sub

    Private Sub btnAceptarif_Click(sender As Object, e As EventArgs) Handles btnAceptarif.Click
        Dim palabra As String = txtbif.Text
        Dim numero As Integer = txtNumeroIf.Text

        If palabra = "hola" Then
            ' Cuerpo del if
            lblMensajeIf.Text = "El mensaje es Hola"

            If numero > 3 And numero < 5 Then
                lblMensajeIf.Text = "Aceptado"
            Else
                lblMensajeIf.Text = "Rechazado"
            End If

        ElseIf palabra = "adios" And numero > 3 Then
            ' Cuerpo del else if
            ' lblMensajeIf.Text = "El mensaje es " & palabra
            lblMensajeIf.Text = "Aceptado"

        ElseIf palabra = "tenga buen dia" Then
            ' Cuerpo del else if
            lblMensajeIf.Text = "El mensaje es " & palabra

        Else
            ' Cuerpo del else, se ejecuta si no se cumple ninguna evaluacion
            lblMensajeIf.Text = "El texto no es valido!"
        End If


    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim x As Integer = txtSelect.Text

        Select Case x
            Case Is < 6
                lblSelect.Text = "Su numero es menor que 6"
            Case Is < 10
                lblSelect.Text = "Su numero es mayor que 6 y menor que 10"
            Case Is = 20
                lblSelect.Text = "Su numero es 10"
            Case Else
                lblSelect.Text = "Su numero es mayor"
        End Select

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If TextBox3.Visible Then
            TextBox3.Visible = False
        Else
            TextBox3.Visible = True
        End If

        'If CheckBox5.Checked Then
        '    TextBox3.Visible = False
        'Else
        '    TextBox3.Visible = True
        'End If
    End Sub
End Class
