Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Proyecto_en_clase
    Friend Class contacto
        Inherits persona

        Private correo As String
        Private telefono As String

        Public Property Telefono_ As String
            Get
                Return telefono
            End Get
            Set(ByVal value As String)
                telefono = value.Replace(" ", "").Replace("-", "")
            End Set
        End Property

        Public Sub New()
            MyBase.New()
            telefono = String.Empty
        End Sub

        Public Sub New(ByVal nombre As String, ByVal fechaNacimiento As DateTime?, ByVal telefono As String)
            MyBase.New(nombre, fechaNacimiento)
            telefono = telefono
        End Sub

        Public Property correo_ As String
            Get
                Return correo
            End Get
            Set(value As String)
                correo = correo
                correo = value.Replace(" ", "").Replace("-", "")
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return MyBase.ToString() & " " & telefono
        End Function

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
