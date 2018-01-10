Public Class frm_proveedores
    Dim proveedores As New func_proveedores()

    Dim dt_proveedores As New DataTable

    Private Sub frm_proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()

    End Sub

    Private Sub habilitar()
        Me.txt_codigo.Enabled = True
        Me.txt_nombre_proveedor.Enabled = True
        Me.txt_ruc.Enabled = True
        Me.txt_email.Enabled = True
        Me.txt_telefono.Enabled = True
        Me.txt_codigo.Focus()

    End Sub


    Private Sub listar()
        dt_proveedores = proveedores.listar("SELECT * FROM proveedores")
        grid_proveedores.DataSource = dt_proveedores

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        habilitar()

    End Sub
End Class