Imports Npgsql

Public Class func_articulos

    Inherits conexion
    Dim util As New utilidades()


    Public Function id_articulo() As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT NEXTVAL('articulos_id_articulo_seq')", cnn)
            da.Fill(dt)

            If dt.Rows.Count() <> 0 Then
                Return CInt(dt.Rows(0).Item(0))
            Else
                util.mensajes("No existe secuencia para articulo", "func_articulos")
                Return 0
            End If
        Catch ex As Exception
            util.mensajes("Error al listar Articulos: " + ex.Message, "func_articulos")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function listar(ByVal sql As String) As DataTable
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(sql, cnn)
            da.Fill(dt)

            Return dt
        Catch ex As Exception
            util.mensajes("Error al listar Articulos: " + ex.Message, "func_articulos")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(ByVal id_articulo As Integer, ByVal nombre As String, ByVal comentario As String, ByVal codigo_articulo As String,
                             ByVal costo_unitario As Integer, ByVal precio_venta As Integer, ByVal tipo_articulo As String) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO articulos(id_articulo, nombre, comentario, codigo_articulo,  
                                            costo_unitario, precio_venta, tipo_articulo)
                                            VALUES (@id_articulo, @nombre, @comentario, @codigo_articulo, 
                                            @costo_unitario, @precio_venta, @tipo_articulo)", cnn)

            comand.Parameters.AddWithValue("@id_articulo", id_articulo)
            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@comentario", comentario)
            comand.Parameters.AddWithValue("@codigo_articulo", codigo_articulo)
            comand.Parameters.AddWithValue("@costo_unitario", costo_unitario)
            comand.Parameters.AddWithValue("@precio_venta", precio_venta)
            comand.Parameters.AddWithValue("@tipo_articulo", tipo_articulo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Articulo: " + ex.Message, "func_articulos")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar(ByVal nombre As String, ByVal comentario As String, ByVal codigo_articulo As String,
                               ByVal costo_unitario As Integer, ByVal precio_venta As Integer,
                               ByVal tipo_articulo As String, ByVal id_articulo As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE articulos SET nombre=@nombre, comentario=@comentario, codigo_articulo=@codigo_articulo,  
                                            costo_unitario=@costo_unitario, precio_venta=@precio_venta, tipo_articulo=@tipo_articulo, 
                                            fecha_mod=now() WHERE id_articulo=@id_articulo", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@comentario", comentario)
            comand.Parameters.AddWithValue("@codigo_articulo", codigo_articulo)
            comand.Parameters.AddWithValue("@costo_unitario", costo_unitario)
            comand.Parameters.AddWithValue("@precio_venta", precio_venta)
            comand.Parameters.AddWithValue("@tipo_articulo", tipo_articulo)
            comand.Parameters.AddWithValue("@id_articulo", id_articulo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Articulo: " + ex.Message, "func_articulos")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar(ByVal id_articulo As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM articulos WHERE id_articulo=@id_articulo", cnn)

            comand.Parameters.AddWithValue("@id_articulo", id_articulo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Articulo: " + ex.Message, "func_articulos")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_articulo_materiales(ByVal id_articulo As Integer, ByVal id_material As Integer, ByVal cantidad As Double) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO articulo_materiales(id_articulo, id_material, cantidad)
                                            VALUES (@id_articulo, @id_material, @cantidad)", cnn)

            comand.Parameters.AddWithValue("@id_articulo", id_articulo)
            comand.Parameters.AddWithValue("@id_material", id_material)
            comand.Parameters.AddWithValue("@cantidad", cantidad)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Materiales del Articulo: " + ex.Message, "func_articulos")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar_articulo_materiales(ByVal id_articulo As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM articulo_materiales WHERE id_articulo=@id_articulo", cnn)

            comand.Parameters.AddWithValue("@id_articulo", id_articulo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Materiales del Articulo: " + ex.Message, "func_articulos")
            Return False
        Finally
            desconectar()
        End Try
    End Function


End Class
