Imports Npgsql

Public Class func_empleados

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
            util.mensajes("Error al listar Empleados: " + ex.Message, "func_empleados")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(ByVal nombres As String, ByVal apellidos As String, ByVal telefono As String, ByVal ciudad As String,
                             ByVal direccion As String) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO empleados (nombres, apellidos, telefono, ciudad, direccion)
                                            VALUES (@nombres, @apellidos, @telefono, @ciudad, @direccion)", cnn)

            comand.Parameters.AddWithValue("@nombres", nombres)
            comand.Parameters.AddWithValue("@apellidos", apellidos)
            comand.Parameters.AddWithValue("@telefono", telefono)
            comand.Parameters.AddWithValue("@ciudad", ciudad)
            comand.Parameters.AddWithValue("@direccion", direccion)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Empleado: " + ex.Message, "func_empleados")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function actualizar(ByVal nombres As String, ByVal apellidos As String, ByVal telefono As String,
                             ByVal ciudad As String, ByVal direccion As String, ByVal id_empleado As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE empleados SET nombres=@nombres, apellidos=@apellidos,telefono=@telefono, 
                                            ciudad=@ciudad, direccion=@direccion,  fecha_mod=now() WHERE id_empleado=@id_empleado", cnn)

            comand.Parameters.AddWithValue("@nombres", nombres)
            comand.Parameters.AddWithValue("@apellidos", apellidos)
            comand.Parameters.AddWithValue("@telefono", telefono)
            comand.Parameters.AddWithValue("@ciudad", ciudad)
            comand.Parameters.AddWithValue("@direccion", direccion)
            comand.Parameters.AddWithValue("@id_empleado", id_empleado)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Empleado: " + ex.Message, "func_empleados")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar(ByVal id_empleado As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE DROP empleados WHERE id_empleado=@id_empleado", cnn)

            comand.Parameters.AddWithValue("@id_empleado", id_empleado)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Empleado: " + ex.Message, "func_empleados")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
