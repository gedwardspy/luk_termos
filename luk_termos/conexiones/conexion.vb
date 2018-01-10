Imports System.Collections
Imports System.IO
Imports Npgsql

Public Class conexion

    Inherits utilidades

    Private cadena As String = CType("User ID=" + parametrosConexion(1) + ";Password=" + parametrosConexion(2) + ";Host=192.168.10.30;Port=5432;Database=luk_termos", String)
    Public cnn As NpgsqlConnection
    Private execute As NpgsqlCommand
    Private dr As NpgsqlDataReader

    Public Sub conectar()
        Try
            cnn = New NpgsqlConnection(cadena)
            cnn.Open()
        Catch ex As Exception
            mensajes("Error al conectarse a Base de Datos: " + ex.Message, "conexion.vb")
        End Try
    End Sub

    Public Function desconectar()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            mensajes("Error al desconectarse de Base de Datos: " + ex.Message, "conexion.vb")
            Return False
        End Try
    End Function

    'funcion para obtener datos de la conexion a base de datos
    Public Function parametrosConexion()
        Dim directorio As String
        directorio = My.Application.Info.DirectoryPath & "\conexion.txt"
        Dim objReader As New StreamReader(directorio)
        Dim sLine As String = ""
        Dim arrText As New ArrayList()

        Do
            sLine = objReader.ReadLine()
            If Not sLine Is Nothing Then
                arrText.Add(sLine)
            End If
        Loop Until sLine Is Nothing
        objReader.Close()
        Return arrText
    End Function


End Class
