Public Class frm_vista_materiales

    Private material As New func_materiales()
    Private dt_materiales As New DataTable()
    Public FRM_ACTIVO As String = ""

    Private Sub frm_vista_materiales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Private Sub listar()
        dt_materiales.Clear()
        dt_materiales = material.listar("SELECT id_material, nombre, codigo FROM materiales WHERE nombre LIKE '%" + txt_Descripcion.Text + "%'")
        grid_materiales.DataSource = dt_materiales
    End Sub

    Private Sub enviar_id(ByVal id As Integer)
        If FRM_ACTIVO = "frm_articulos" Then
            frm_articulos.add_materiales(id)
            Me.Close()
        End If
    End Sub

    Private Sub txt_Descripcion_TextChanged(sender As Object, e As EventArgs) Handles txt_Descripcion.TextChanged
        listar()
    End Sub

    Private Sub grid_materiales_Click(sender As Object, e As EventArgs) Handles grid_materiales.Click
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        enviar_id(GridView1.GetRowCellValue(rowhandle, "id_material").ToString())
    End Sub

    Private Sub grid_materiales_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_materiales.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            enviar_id(GridView1.GetRowCellValue(rowhandle, "id_material").ToString())
        End If
    End Sub
End Class