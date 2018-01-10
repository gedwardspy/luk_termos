Imports DevExpress.XtraEditors

Public Class frm_articulos

    Private Const TITULO_MSJ As String = "<<Registro de Articulos>>"
    Private AGREGAR_MATERIALES As Boolean = False
    Public EXISTE_ARTICULO As Boolean = False

    'Variables para las transacciones de la tabla articulos
    Private ID_ARTICULO As Integer = 0
    Private NOMBRE As String = ""
    Private DESCRIPCION As String = ""
    Private CODIGO As String = ""
    Private COSTO_UNITARIO As Integer = 0
    Private PRECIO_VENTA As Integer = 0
    Private TIPO_ARTICULO As String = ""

    'Variables para las transacciones de la tabla articulo_materiales
    Private ID_MATERIAL As Integer = 0
    Private CANTIDAD As Double = 0
    Private COSTO_TOTAL As Integer = 0

    Private util As New utilidades()
    Private articulos As New func_articulos()
    Dim dt_items_materiales As New DataTable

    Private Sub frm_articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desabilitar()
        btn_nuevo.Focus()
    End Sub

    Private Sub desabilitar()
        txt_nombre.Enabled = False
        txt_comentario.Enabled = False
        txt_codigo.Enabled = False
        txt_costo_unitario.Enabled = False
        txt_precio_venta.Enabled = False
        cbo_tipo_articulo.Enabled = False
        btn_confirmar.Enabled = False
        btn_cancelar.Enabled = False
        lbl_mensaje.Visible = False
        btn_agregar_material.Enabled = False
    End Sub

    Private Sub habilitar()
        txt_nombre.Enabled = True
        txt_comentario.Enabled = True
        txt_codigo.Enabled = True
        txt_costo_unitario.Enabled = True
        txt_precio_venta.Enabled = True
        cbo_tipo_articulo.Enabled = True
        btn_confirmar.Enabled = True
        btn_cancelar.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_nombre.Text = ""
        txt_comentario.Text = ""
        txt_codigo.Text = ""
        txt_costo_unitario.Text = ""
        txt_precio_venta.Text = ""
        cbo_tipo_articulo.SelectedIndex = 0
        grid_articulos.DataSource = Nothing
        lbl_mensaje.Visible = False
    End Sub

    Private Sub nuevo()
        ID_ARTICULO = articulos.id_articulo()
        If ID_ARTICULO > 0 Then
            habilitar()
            limpiar()
            txt_nombre.Focus()
        End If
    End Sub

    Private Function validar_cantidad_materiales() As Boolean
        Dim cantidad As Double = 0.0
        Dim validar As String
        For i As Integer = 0 To GridView1.RowCount
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            validar = GridView1.GetFocusedDisplayText()
            If validar <> "" Then
                If CInt(validar) > 0 Then
                    cantidad += CDbl(GridView1.GetFocusedDisplayText())
                End If
            End If
        Next

        Return cantidad >= 0
    End Function

    Private Sub listar_materiales()
        dt_items_materiales.Clear()
        dt_items_materiales = articulos.listar("SELECT *, 0.0 AS cantidad FROM materiales ORDER BY nombre ASC")
        grid_articulos.DataSource = dt_items_materiales
    End Sub

    Private Sub insertar_actualizar_articulo()
        NOMBRE = txt_nombre.Text
        DESCRIPCION = txt_comentario.Text
        CODIGO = txt_codigo.Text
        If txt_costo_unitario.Text = "" Then
            COSTO_UNITARIO = 0
        Else
            COSTO_UNITARIO = CInt(txt_costo_unitario.Text)
        End If

        If txt_precio_venta.Text = "" Then
            PRECIO_VENTA = 0
        Else
            PRECIO_VENTA = CInt(txt_precio_venta.Text)
        End If

        TIPO_ARTICULO = cbo_tipo_articulo.SelectedItem.ToString()

        If NOMBRE = "" Then
            util.mensajes("Ingrese nombre del Articulo", TITULO_MSJ)
            txt_nombre.Focus()
        ElseIf CODIGO = "" Then
            util.mensajes("Ingrese codigo para el articulo", TITULO_MSJ)
        ElseIf cbo_tipo_articulo.SelectedIndex <= 0 Then
            util.mensajes("Seleccione el Tipo de Articulo Articulo", TITULO_MSJ)
            cbo_tipo_articulo.Focus()
        Else
            If EXISTE_ARTICULO = False Then
                If articulos.insertar(ID_ARTICULO, NOMBRE, DESCRIPCION, CODIGO, COSTO_UNITARIO, PRECIO_VENTA, TIPO_ARTICULO) Then
                    If AGREGAR_MATERIALES Then
                        If insertar_materiales_articulo() Then
                            util.mensajes("Articulo Registrado", TITULO_MSJ)
                            limpiar()
                            desabilitar()
                            btn_nuevo.Focus()
                        Else
                            util.mensajes("Materiales del Articulo no Registrados", TITULO_MSJ)
                        End If
                    Else
                        util.mensajes("Articulo Registrado", TITULO_MSJ)
                        limpiar()
                        desabilitar()
                        btn_nuevo.Focus()
                    End If
                Else
                    util.mensajes("Articulo no Registrado", TITULO_MSJ)
                End If
            End If

            If EXISTE_ARTICULO = True Then
                If articulos.actualizar(NOMBRE, DESCRIPCION, CODIGO, COSTO_UNITARIO, PRECIO_VENTA, TIPO_ARTICULO, ID_ARTICULO) Then
                    If AGREGAR_MATERIALES Then
                        If dt_items_materiales.Rows.Count() <> 0 Then

                            If eliminar_materiales_articulo(ID_ARTICULO) Then
                                If insertar_materiales_articulo() Then
                                    util.mensajes("Articulo Actualizado", TITULO_MSJ)
                                    limpiar()
                                    desabilitar()
                                    btn_nuevo.Focus()
                                Else
                                    util.mensajes("Materiales del Articulo no Actualizados", TITULO_MSJ)
                                End If
                            Else
                                If insertar_materiales_articulo() Then
                                    util.mensajes("Articulo Actualizado", TITULO_MSJ)
                                    limpiar()
                                    desabilitar()
                                    btn_nuevo.Focus()
                                Else
                                    util.mensajes("Materiales del Articulo no Actualizados", TITULO_MSJ)
                                End If
                            End If
                        Else
                            util.mensajes("Debe asignar materiales al articulo", TITULO_MSJ)
                        End If
                    Else
                        util.mensajes("Articulo Registrado", TITULO_MSJ)
                    End If
                Else
                    util.mensajes("Articulo no Actualizado", TITULO_MSJ)
                End If
            End If
        End If

    End Sub

    Private Function insertar_materiales_articulo() As Boolean
        Dim resultado As Boolean = False
        Dim rowhandle As Integer
        Dim cant As Double = 0

        For i As Integer = 0 To GridView1.RowCount - 1
            'MANDAMOS EL FOCO A LA FILA <<i>> MEDIANTE EL FocusedRowHandle
            GridView1.FocusedRowHandle = i
            'OBTENEMOS LA FILA EN LA QUE SE ENCUENTRA EL FOCO
            rowhandle = GridView1.FocusedRowHandle
            'OBTENEMOS TODOS LOS VALORES
            ID_MATERIAL = CInt(GridView1.GetRowCellValue(rowhandle, "id_material").ToString())
            'MANDAMOS EL FOCO A LA COLUMNA DE CANTIDAD PARA OBTENER SU VALOR
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            'OBTENEMOS EL VALOR DE LA COLUMNA CANTIDAD
            cant = CDbl(GridView1.GetFocusedDisplayText())

            If cant > 0.0 Then
                CANTIDAD = CDbl(GridView1.GetFocusedDisplayText())
                resultado = articulos.insertar_articulo_materiales(ID_ARTICULO, ID_MATERIAL, CANTIDAD)
                If resultado = False Then
                    Return False
                End If
            End If
        Next

        Return resultado
    End Function

    Private Function eliminar_materiales_articulo(ByVal id_articulo As Integer) As Boolean
        Return articulos.eliminar_articulo_materiales(id_articulo)
    End Function

    Public Sub buscar_articulo(ByVal id As Integer)
        Dim dt_articulos As New DataTable()
        dt_articulos = articulos.listar("SELECT * FROM articulos WHERE id_articulo = " + id.ToString() + "")

        If dt_articulos.Rows.Count() <> 0 Then
            ID_ARTICULO = CInt(dt_articulos.Rows(0).Item(0).ToString())
            txt_comentario.Text = dt_articulos.Rows(0).Item(1).ToString()
            txt_codigo.Text = dt_articulos.Rows(0).Item(2).ToString()
            txt_costo_unitario.Text = dt_articulos.Rows(0).Item(3).ToString()
            txt_precio_venta.Text = dt_articulos.Rows(0).Item(4).ToString()
            cbo_tipo_articulo.SelectedItem = dt_articulos.Rows(0).Item(5).ToString()
            txt_nombre.Text = dt_articulos.Rows(0).Item(6).ToString()
            buscar_materiales()
            habilitar()
            txt_nombre.Focus()

            GridView1.FocusedRowHandle = GridView1.RowCount()
            btn_agregar_material.Enabled = True
        Else
            util.mensajes("Articulo no definido", TITULO_MSJ)
        End If
    End Sub

    Private Sub buscar_materiales()
        dt_items_materiales.Clear()
        dt_items_materiales = articulos.listar("SELECT a.*, m.nombre FROM articulo_materiales a INNER JOIN materiales m
                                          ON a.id_material = m.id_material WHERE id_articulo = " + ID_ARTICULO.ToString() + "")
        grid_articulos.DataSource = Nothing
        grid_articulos.DataSource = dt_items_materiales
    End Sub

    Public Sub add_materiales(ByVal id As Integer)
        Dim dt_material As New DataTable()
        dt_material = articulos.listar("SELECT id_material, nombre, 0 AS cantidad FROM materiales WHERE id_material=" + id.ToString() + "")

        If dt_material.Rows.Count() <> 0 Then

            For Each dr As DataRow In dt_items_materiales.Rows
                If dr("id_material") = dt_material.Rows(0).Item(0) Then
                    util.mensajes(dt_material.Rows(0).Item(1).ToString() + ", ya esta asignado al Articulo", TITULO_MSJ)
                    Return
                End If
            Next

            Dim row As DataRow = dt_items_materiales.NewRow()
            row("id_material") = dt_material.Rows(0).Item(0)
            row("nombre") = dt_material.Rows(0).Item(1)
            row("cantidad") = 0

            dt_items_materiales.Rows.Add(row)
            grid_articulos.DataSource = dt_items_materiales
        Else
            util.mensajes("El material seleccionado no existe", TITULO_MSJ)
        End If

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        EXISTE_ARTICULO = False
        nuevo()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If util.msj_confirmacion("Deseas confirmar la operacion?", TITULO_MSJ) Then
            If AGREGAR_MATERIALES Then
                If validar_cantidad_materiales() = False Then
                    util.mensajes("Debe asignar materiales al Articulo Personalizado", TITULO_MSJ)
                    grid_articulos.Focus()
                Else
                    insertar_actualizar_articulo()
                End If
            Else
                insertar_actualizar_articulo()
            End If
        Else
            btn_confirmar.Focus()
        End If
    End Sub

    Private Sub cbo_tipo_articulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_articulo.SelectedIndexChanged
        If cbo_tipo_articulo.SelectedIndex = 2 Then
            lbl_mensaje.Visible = True
            listar_materiales()
            AGREGAR_MATERIALES = True
        Else
            grid_articulos.DataSource = Nothing
            lbl_mensaje.Visible = False
            AGREGAR_MATERIALES = False
        End If
    End Sub

    Private Sub cbo_tipo_articulo_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_tipo_articulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_confirmar.Focus()
        End If
    End Sub

    Private Sub col_txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles col_txt_cantidad.KeyPress
        'SI PRECIONA PUNTO(.) EN VEZ DE COMA(,)DEBEMOS CAMBIARLO POR COMA(,) 
        'PARA QUE LA COLUMNA CANTIDAD TOME CORRECTAMENTE LOS DATOS
        If e.KeyChar = "," Then

        ElseIf e.KeyChar = "." Then
            'ENVIA PULSACION DE COMA (,)
            SendKeys.Send(Microsoft.VisualBasic.Chr(44))
            e.Handled = True
        Else
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        limpiar()
        desabilitar()
        btn_nuevo.Focus()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim frm As New frm_vista_articulos()
        frm.FRM_ACTIVO = "frm_articulos"
        frm.ShowDialog()
    End Sub

    Private Sub btn_agregar_material_Click(sender As Object, e As EventArgs) Handles btn_agregar_material.Click
        Dim frm As New frm_vista_materiales()
        frm.FRM_ACTIVO = "frm_articulos"
        frm.ShowDialog()
    End Sub
End Class