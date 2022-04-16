<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbContador = New System.Windows.Forms.ListBox()
        Me.btnContador = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbxWhile = New System.Windows.Forms.ListBox()
        Me.btnWhile = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbxDoWhile = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbContador
        '
        Me.lbContador.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbContador.FormattingEnabled = True
        Me.lbContador.ItemHeight = 18
        Me.lbContador.Location = New System.Drawing.Point(17, 19)
        Me.lbContador.Name = "lbContador"
        Me.lbContador.Size = New System.Drawing.Size(221, 148)
        Me.lbContador.TabIndex = 0
        '
        'btnContador
        '
        Me.btnContador.Location = New System.Drawing.Point(17, 175)
        Me.btnContador.Name = "btnContador"
        Me.btnContador.Size = New System.Drawing.Size(75, 23)
        Me.btnContador.TabIndex = 1
        Me.btnContador.Text = "Contador"
        Me.btnContador.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbContador)
        Me.GroupBox1.Controls.Add(Me.btnContador)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 214)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "For..Next"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnWhile)
        Me.GroupBox2.Controls.Add(Me.lbxWhile)
        Me.GroupBox2.Location = New System.Drawing.Point(302, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(236, 214)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "While"
        '
        'lbxWhile
        '
        Me.lbxWhile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxWhile.FormattingEnabled = True
        Me.lbxWhile.ItemHeight = 18
        Me.lbxWhile.Location = New System.Drawing.Point(15, 19)
        Me.lbxWhile.Name = "lbxWhile"
        Me.lbxWhile.Size = New System.Drawing.Size(215, 148)
        Me.lbxWhile.TabIndex = 0
        '
        'btnWhile
        '
        Me.btnWhile.Location = New System.Drawing.Point(24, 175)
        Me.btnWhile.Name = "btnWhile"
        Me.btnWhile.Size = New System.Drawing.Size(75, 23)
        Me.btnWhile.TabIndex = 1
        Me.btnWhile.Text = "Contador"
        Me.btnWhile.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.lbxDoWhile)
        Me.GroupBox3.Location = New System.Drawing.Point(561, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(241, 214)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DoWhile"
        '
        'lbxDoWhile
        '
        Me.lbxDoWhile.FormattingEnabled = True
        Me.lbxDoWhile.Location = New System.Drawing.Point(6, 19)
        Me.lbxDoWhile.Name = "lbxDoWhile"
        Me.lbxDoWhile.Size = New System.Drawing.Size(229, 147)
        Me.lbxDoWhile.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Contador"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 393)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbContador As ListBox
    Friend WithEvents btnContador As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnWhile As Button
    Friend WithEvents lbxWhile As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbxDoWhile As ListBox
End Class
