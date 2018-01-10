Imports Npgsql

Public Class func_materiales

    Inherits conexion
    Dim util As New utilidades()

    Public Function listar(ByVal sql As String) As DataTable
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(sql, cnn)
            da.Fill(dt)

            Return dt
        Catch ex As Exception
            util.mensajes("Error al listar Materiales: " + ex.Message, "func_materiales")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(ByVal nombre As String, ByVal codigo As String, ByVal id_usuario As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO materiales(nombre, codigo, id_usuario)
                                            VALUES (@nombre, @codigo, @id_usuario)", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@codigo", codigo)
            comand.Parameters.AddWithValue("@id_usuario", id_usuario)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Material: " + ex.Message, "func_materiales")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function actualizar(ByVal nombre As String, ByVal codigo As String, ByVal id_usuario As Integer, ByVal id_material As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE materiales SET nombre=@nombre, codigo=@codigo, id_usuario=@id_usuario, fecha_mod=now()
                                            WHERE id_material=@id_material", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@codigo", codigo)
            comand.Parameters.AddWithValue("@id_usuario", id_usuario)
            comand.Parameters.AddWithValue("@id_material", id_material)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Material: " + ex.Message, "func_materiales")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar(ByVal id_material As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM materiales WHERE id_material=@id_material", cnn)

            comand.Parameters.AddWithValue("@id_material", id_material)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Material: " + ex.Message, "func_materiales")
            Return False
        Finally
            desconectar()
        End Try
    End Function
End Class
