Imports Npgsql
Public Class func_proveedores
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
            util.mensajes("Error al listar Proveedores: " + ex.Message, "func_proveedores")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(ByVal nombre As String, ByVal ruc As String, ByVal telefono As String, ByVal correo As String, ByVal activo As Boolean) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO proveedores(nombre, ruc, telefono,correo,activo)
                                            VALUES (@nombre, @ruc,  @telefono,@correo,@activo)", cnn)
            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@ruc", ruc)
            comand.Parameters.AddWithValue("@telefono", telefono)
            comand.Parameters.AddWithValue("@correo", correo)
            comand.Parameters.AddWithValue("@activo", activo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Proveedor: " + ex.Message, "func_proveedores")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar(ByVal nombre As String, ByVal ruc As String, ByVal telefono As String,
                             ByVal correo As String, ByVal activo As Boolean, ByVal id_proveedor As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE proveedores SET nombre=@nombre,telefono=@telefono, ruc=@ruc, correo=@correo, 
                                             activo=@activo, fecha_mod=now() WHERE id_proveedor=@id_proveedor", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@ruc", ruc)
            comand.Parameters.AddWithValue("@telefono", telefono)
            comand.Parameters.AddWithValue("@correo", correo)
            comand.Parameters.AddWithValue("@activo", activo)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Proveedor: " + ex.Message, "func_proveedores")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar(ByVal id_cliente As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE DROP clientes WHERE id_cliente=@id_cliente", cnn)

            comand.Parameters.AddWithValue("@id_cliente", id_cliente)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Proveedor: " + ex.Message, "func_proveedores")
            Return False
        Finally
            desconectar()
        End Try
    End Function


End Class