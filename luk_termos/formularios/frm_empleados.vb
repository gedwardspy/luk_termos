Public Class frm_empleados
    Dim empleado As New func_empleados()
    Dim util As New utilidades()
    Dim dt_empleados As New DataTable()

    Private Const TITULO_MSJ As String = "<<Registro de Empleados>>"
    Private ID_EMPLEADO As Integer = 0
    Private NOMBRES As String = ""
    Private APELLIDOS As String = ""
    Private TELEFONO As String = ""
    Private CIUDAD As String = ""
    Private DIRECCION As String = ""

    Private Sub frm_empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desabilitar()
        listar()
    End Sub

    Private Sub desabilitar()
        txt_nombres.Enabled = False
        txt_apellidos.Enabled = False
        txt_telefono.Enabled = False
        txt_ciudad.Enabled = False
        txt_direccion.Enabled = False
        btn_confirmar.Enabled = False
    End Sub

    Private Sub habilitar()
        txt_nombres.Enabled = True
        txt_apellidos.Enabled = True
        txt_telefono.Enabled = True
        txt_ciudad.Enabled = True
        txt_direccion.Enabled = True
        btn_confirmar.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_nombres.Text = ""
        txt_apellidos.Text = ""
        txt_telefono.Text = ""
        txt_ciudad.Text = ""
        txt_direccion.Text = ""
    End Sub

    Private Sub listar()
        dt_empleados = empleado.listar("SELECT * FROM empleados ORDER BY fecha_cre DESC,  fecha_mod DESC")
        grid_empleados.DataSource = dt_empleados
    End Sub

    Private Sub insertar_actualizar()
        NOMBRES = txt_nombres.Text
        APELLIDOS = txt_apellidos.Text
        TELEFONO = txt_telefono.Text
        CIUDAD = txt_ciudad.Text
        DIRECCION = txt_direccion.Text

        If NOMBRES = "" Then
            util.mensajes("Ingrese nombre/s para el empleado", TITULO_MSJ)
            txt_nombres.Focus()
        ElseIf APELLIDOS = "" Then
            util.mensajes("Ingrese apellido para el empleado", TITULO_MSJ)
            txt_apellidos.Focus()
        ElseIf TELEFONO = "" Then
            util.mensajes("Ingrese telefono del empleado", TITULO_MSJ)
            txt_telefono.Focus()
        ElseIf CIUDAD = "" Then
            util.mensajes("Ingrese ciudad del empleado", TITULO_MSJ)
            txt_ciudad.Focus()
        ElseIf DIRECCION = "" Then
            util.mensajes("Ingrese direccion del empleado", TITULO_MSJ)
            txt_direccion.Focus()
        Else
            If ID_EMPLEADO <= 0 Then
                If empleado.insertar(NOMBRES, APELLIDOS, TELEFONO, CIUDAD, DIRECCION) Then
                    util.mensajes("Empleado Registrado", TITULO_MSJ)
                    limpiar()
                    desabilitar()
                    btn_nuevo.Focus()
                Else
                    util.mensajes("Empleado no Registrado", TITULO_MSJ)
                End If
            Else
                If empleado.actualizar(NOMBRES, APELLIDOS, TELEFONO, CIUDAD, DIRECCION, ID_EMPLEADO) Then
                    util.mensajes("Empleado Actualizado", TITULO_MSJ)
                    limpiar()
                    desabilitar()
                    btn_nuevo.Focus()
                Else
                    util.mensajes("Empleado no Actualizado", TITULO_MSJ)
                End If
            End If

            listar()
        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
        habilitar()
        txt_nombres.Focus()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) Then
            insertar_actualizar()
        End If
    End Sub

    Private Sub grid_empleados_Click(sender As Object, e As EventArgs) Handles grid_empleados.Click
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        ID_EMPLEADO = CInt(GridView1.GetRowCellValue(rowhandle, "id_empleado").ToString())
        txt_nombres.Text = GridView1.GetRowCellValue(rowhandle, "nombres").ToString()
        txt_apellidos.Text = GridView1.GetRowCellValue(rowhandle, "apellidos").ToString()
        txt_telefono.Text = GridView1.GetRowCellValue(rowhandle, "telefono").ToString()
        txt_ciudad.Text = GridView1.GetRowCellValue(rowhandle, "ciudad").ToString()
        txt_direccion.Text = GridView1.GetRowCellValue(rowhandle, "direccion").ToString()

        habilitar()
    End Sub

    Private Sub txt_direccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_direccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_confirmar.Focus()
        End If
    End Sub
End Class