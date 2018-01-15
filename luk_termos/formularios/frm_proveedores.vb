Public Class frm_proveedores
    Dim proveedores As New func_proveedores()
    Dim dt_proveedores As New DataTable
    Dim util As New utilidades



    Private Sub frm_proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()

    End Sub

    Private Sub habilitar()
        'Me.txt_codigo.Enabled = True
        Me.txt_nombre_proveedor.Enabled = True
        Me.txt_ruc.Enabled = True
        Me.txt_email.Enabled = True
        Me.txt_telefono.Enabled = True
        Me.chk_activo.Enabled = True
        Me.txt_nombre_proveedor.Focus()
    End Sub

    Private Sub deshabilitar()
        Me.txt_codigo.Enabled = False
        Me.txt_nombre_proveedor.Enabled = False
        Me.txt_ruc.Enabled = False
        Me.txt_email.Enabled = False
        Me.txt_telefono.Enabled = False
        Me.chk_activo.Enabled = False
        Me.txt_nombre_proveedor.Focus()
        Me.grid_proveedores.Enabled = True
        Me.btn_modificar.Text = "Modificar"
    End Sub


    Sub limpiar_variables()
        Me.txt_codigo.Text = ""
        Me.txt_nombre_proveedor.Text = ""
        Me.txt_ruc.Text = ""
        Me.txt_email.Text = ""
        Me.txt_telefono.Text = ""
        Me.chk_activo.Checked = False

        Me.txt_nombre_proveedor.Focus()
    End Sub



    Private Sub listar()
        dt_proveedores = proveedores.listar("SELECT * FROM proveedores order by fecha_cre")
        grid_proveedores.DataSource = dt_proveedores

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        limpiar_variables()
        deshabilitar()
        btn_modificar.Enabled = True

        btn_agregar.Enabled = True
        Me.btn_agregar.Text = "Agregar"
        Me.btn_modificar.Text = "Modificar"

        Me.grid_proveedores.Enabled = True


    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        habilitar()
        Me.grid_proveedores.Enabled = False
        btn_agregar.Enabled = False

        If btn_modificar.Text = "Guardar" Then
            guardar()
            listar()
            deshabilitar()
            limpiar_variables()
            btn_agregar.Enabled = True


        Else
            btn_modificar.Text = "Guardar"



        End If


    End Sub

    Private Sub GridView1_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged



        Dim rowhandle As Integer = Me.GridView1.FocusedRowHandle
        Me.txt_nombre_proveedor.Text = Me.GridView1.GetRowCellValue(rowhandle, "nombre").ToString




    End Sub


    Sub obtener_registros()
        Dim rowhandle As Integer = Me.GridView1.FocusedRowHandle
        Me.txt_nombre_proveedor.Text = Me.GridView1.GetRowCellValue(rowhandle, "nombre").ToString
        Me.txt_ruc.Text = Me.GridView1.GetRowCellValue(rowhandle, "ruc").ToString
        Me.txt_telefono.Text = Me.GridView1.GetRowCellValue(rowhandle, "telefono").ToString
        Me.txt_email.Text = Me.GridView1.GetRowCellValue(rowhandle, "correo").ToString
        Me.txt_codigo.Text = Me.GridView1.GetRowCellValue(rowhandle, "id_proveedor").ToString
        Me.chk_activo.Checked = CBool(Me.GridView1.GetRowCellValue(rowhandle, "activo").ToString)











    End Sub


    Sub guardar()
        Dim codigo As Integer
        Dim nombre As String
        Dim ruc As String
        Dim telefono As String
        Dim email As String
        Dim activo As Boolean
        'asignar los valores
        nombre = Me.txt_nombre_proveedor.Text
        ruc = Me.txt_ruc.Text
        telefono = Me.txt_telefono.Text
        email = Me.txt_email.Text
        activo = Me.chk_activo.Checked



        If btn_agregar.Text = "Guardar" Then
            activo = True
            proveedores.insertar(nombre, ruc, telefono, email, activo)
        Else
            codigo = CInt(txt_codigo.Text)
            proveedores.actualizar(nombre, ruc, telefono, email, activo, codigo)
            util.msj_confirmacion("PROVEEDOR MODIFICADO CORRECTAMENTE", "PROVEEDOR MODIFICADO")

        End If


    End Sub




    Private Sub grid_proveedores_Click(sender As Object, e As EventArgs) Handles grid_proveedores.Click
        obtener_registros()

    End Sub




    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim rowhandle As Integer = Me.GridView1.FocusedRowHandle
        If rowhandle >= 0 Then
            Me.txt_nombre_proveedor.Text = Me.GridView1.GetRowCellValue(rowhandle, "nombre").ToString
            obtener_registros()
        End If

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        If Me.btn_agregar.Text = "Guardar" Then
            guardar()
            util.mensajes("PROVEEDOR REGISTRADO CON EXITO", "PROVEEDOR REGISTRADO")
            deshabilitar()
            listar()
            limpiar_variables()
            Me.grid_proveedores.Enabled = True
            Me.btn_agregar.Text = "AGREGAR"
            Me.btn_modificar.Enabled = True


        Else
            habilitar()
            Me.btn_agregar.Text = "Guardar"
            Me.grid_proveedores.Enabled = False
            Me.btn_modificar.Enabled = False
            limpiar_variables()

        End If





    End Sub



    Private Sub txt_nombre_proveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre_proveedor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_ruc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ruc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub txt_telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_email.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub chk_activo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chk_activo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GridView1.ShowPrintPreview()
    End Sub
End Class