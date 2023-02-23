Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Proyecto_en_Clase_WF_en_WB.Proyecto_en_clase

Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'End Sub

    Dim cantidadPersonas As Int64 = 0
    Dim RegistradosInt As Int64 = 0
    Dim arreglo() As contacto

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub
    Private Sub Imprimir_Click(sender As Object, e As EventArgs) Handles Guardar.Click

        If (RegistradosInt < cantidadPersonas) Then
            Dim nuevocontacto = New contacto()

            nuevocontacto.FechaNacimiento_ = DateTimePicker1.Value
            nuevocontacto.Nombre_ = txtnombre.Text
            nuevocontacto.Telefono_ = txtTelefono.Text
            nuevocontacto.correo_ = TextBox3.Text
            arreglo(RegistradosInt) = nuevocontacto
            RegistradosInt = RegistradosInt + 1
            Dim nuevaLinea As String = nuevocontacto.Nombre_ + ", " + nuevocontacto.Edad.ToString() + ", " + nuevocontacto.Telefono_.ToString() + ", " + nuevocontacto.correo_.ToString() + Environment.NewLine
            lblInformacion.Text = lblInformacion.Text + nuevaLinea
        Else
            MsgBox("Ya se registraron todos")
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged, TextBox3.TextChanged, TextBox1.TextChanged
        cantidadPersonas = TextBox1.Text
        RegistradosInt = 0
        ReDim arreglo(cantidadPersonas)
    End Sub

    Friend Sub Establecer_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim cuantas As Integer
        cuantas = TextBox1.Text

        cuantas = cuantas

    End Sub
End Class



