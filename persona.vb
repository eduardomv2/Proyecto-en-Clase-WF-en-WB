Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Proyecto_en_clase
    Friend Class persona
        Protected nombre As String
        Protected fechaNacimiento As DateTime?

        Public Property Nombre_ As String
            Get
                Return nombre
            End Get
            Set(ByVal value As String)
                nombre = value
            End Set
        End Property

        Public Property FechaNacimiento_ As DateTime?
            Get
                Return fechaNacimiento
            End Get
            Set(ByVal value As DateTime?)
                fechaNacimiento = value
            End Set
        End Property

        Public ReadOnly Property Edad As Integer
            Get
                Dim edad_ As Integer = DateTime.Today.Year - fechaNacimiento.Value.Year

                If fechaNacimiento > DateTime.Today.AddYears(-edad) Then
                    edad -= 1
                End If

                Dim arregloEdad As Integer() = New Integer() {edad}
                Return edad
            End Get
        End Property

        Public Sub New()
            nombre = String.Empty
            fechaNacimiento = Nothing
        End Sub

        Public Sub New(ByVal nombre As String, ByVal fechaNacimiento As DateTime?)
            Me.nombre = nombre
            Me.fechaNacimiento = fechaNacimiento
        End Sub

        Public Overrides Function ToString() As String
            Return nombre.ToUpper() & " " & Edad
        End Function
    End Class
End Namespace
