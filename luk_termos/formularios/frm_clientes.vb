Public Class frm_clientes

    Private Const TITULO_MSJ = "<<Registro de Clientes>>"

    Private ID_CLIENTE As Integer = 0
    Private NOMBRES As String = ""
    Private APELLIDOS As String = ""
    Private NRO_DOCUMENTO As String = ""
    Private TELEFONO As String = ""
    Private CIUDAD As String = ""
    Private DIRECCION As String = ""

    Dim dt_clientes As New DataTable()
    Dim cliente As New func_clientes()
    Dim util As New utilidades()

    Private Sub frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desabilitar()
        listar()
    End Sub

    Public Sub desabilitar()
        txt_nombres.Enabled = False
        txt_apellidos.Enabled = False
        txt_nro_documeto.Enabled = False
        txt_telefono.Enabled = False
        txt_ciudad.Enabled = False
        txt_direccion.Enabled = False
        btn_confirmar.Enabled = False
    End Sub

    Public Sub habilitar()
        txt_nombres.Enabled = True
        txt_apellidos.Enabled = True
        txt_nro_documeto.Enabled = True
        txt_telefono.Enabled = True
        txt_ciudad.Enabled = True
        txt_direccion.Enabled = True
        btn_confirmar.Enabled = True
    End Sub

    Public Sub limpiar()
        txt_nombres.Text = ""
        txt_apellidos.Text = ""
        txt_nro_documeto.Text = ""
        txt_telefono.Text = ""
        txt_ciudad.Text = ""
        txt_direccion.Text = ""
    End Sub

    Private Sub listar()
        dt_clientes = cliente.listar("SELECT * FROM clientes ORDER BY fecha_cre DESC, fecha_mod DESC")
        grid_clientes.DataSource = dt_clientes
    End Sub

    Public Sub insertar_actualizar()
        NOMBRES = txt_nombres.Text
        APELLIDOS = txt_apellidos.Text
        NRO_DOCUMENTO = txt_nro_documeto.Text
        TELEFONO = txt_telefono.Text
        CIUDAD = txt_ciudad.Text
        DIRECCION = txt_direccion.Text

        If NOMBRES = "" Then
            util.mensajes("Ingrese nombre/s para el cliente", TITULO_MSJ)
            txt_nombres.Focus()
        ElseIf NRO_DOCUMENTO = "" Then
            util.mensajes("Ingrese numero de documento para el cliente", TITULO_MSJ)
            txt_nro_documeto.Focus()
        Else
            If ID_CLIENTE <= 0 Then
                If cliente.insertar(NOMBRES, APELLIDOS, NRO_DOCUMENTO, TELEFONO, CIUDAD, DIRECCION) Then
                    util.mensajes("Cliente Registrado", TITULO_MSJ)
                    limpiar()
                    desabilitar()
                    btn_nuevo.Focus()
                Else
                    util.mensajes("Cliente no Registrado", TITULO_MSJ)
                End If
            Else
                If cliente.actualizar(NOMBRES, APELLIDOS, NRO_DOCUMENTO, TELEFONO, CIUDAD, DIRECCION, ID_CLIENTE) Then
                    util.mensajes("Cliente Actualizado", TITULO_MSJ)
                    limpiar()
                    desabilitar()
                    btn_nuevo.Focus()
                Else
                    util.mensajes("Cliente no Actualizado", TITULO_MSJ)
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
        Else
            util.mensajes("Operacion no Confirmada", TITULO_MSJ)
        End If
    End Sub

    Private Sub grid_clientes_Click(sender As Object, e As EventArgs) Handles grid_clientes.Click
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        ID_CLIENTE = CInt(GridView1.GetRowCellValue(rowhandle, "id_cliente").ToString())
        txt_nombres.Text = GridView1.GetRowCellValue(rowhandle, "nombres").ToString()
        txt_apellidos.Text = GridView1.GetRowCellValue(rowhandle, "apellidos").ToString()
        txt_nro_documeto.Text = GridView1.GetRowCellValue(rowhandle, "numero_documento").ToString()
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