Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'AbrirConexion()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim usuario As String = txtUsuario.Text
        Dim contra As String = txtContra.Text

        'Dim consultaLogin As String = "SELECT * FROM Usuario WHERE username = '" &
        '                            usuario & "' AND password='" & contra & "'"

        Dim consultaLogin As String = String.Format("INSERT INTO Usuario([nombre],[username],[password],[tipo_usuario]) VALUES('{0}','{1}','{2}','{3}')",
                                                    "test2",
                                                    "test2",
                                                    "test2",
                                                    "Cliente")



        Accion(consultaLogin)


        'Dim datos As DataSet = Consulta(consultaLogin)

        ' Primera verificacion: Evaluo si tengo datos
        'If datos.Tables(0).Rows.Count Then
        '    Dim tipoUsuario As String = datos.Tables(0).Rows(0)("tipo_usuario")

        '    If tipoUsuario = "Administrador" Then
        '        Dim adminPantalla As Administrador = New Administrador()
        '        adminPantalla.Show()
        '        Me.Hide()
        '    Else
        '        Dim usuarioPantalla As Cliente = New Cliente()
        '        usuarioPantalla.Show()
        '        Me.Hide()
        '    End If
        'Else
        '    MsgBox("Las credenciales son incorrectas")
        'End If
    End Sub
End Class
