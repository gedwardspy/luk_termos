Public Class frm_vista_articulos

    Private articulos As New func_articulos()
    Private dt_vista_articulos As New DataTable()
    Public FRM_ACTIVO As String = ""

    Private Sub frm_vista_articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Private Sub listar()
        dt_vista_articulos.Clear()
        dt_vista_articulos = articulos.listar("SELECT * FROM articulos WHERE nombre LIKE '%" + txt_Descripcion.Text + "%'")
        grid_articulos.DataSource = dt_vista_articulos
    End Sub

    Private Sub enviar_id(ByVal id As Integer)
        If FRM_ACTIVO = "frm_articulos" Then
            frm_articulos.buscar_articulo(id)
            frm_articulos.EXISTE_ARTICULO = True
            Me.Close()
        End If
    End Sub

    Private Sub txt_Descripcion_TextChanged(sender As Object, e As EventArgs) Handles txt_Descripcion.TextChanged
        listar()
    End Sub

    Private Sub grid_articulos_Click(sender As Object, e As EventArgs) Handles grid_articulos.Click
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        enviar_id(GridView1.GetRowCellValue(rowhandle, "id_articulo").ToString())
    End Sub

    Private Sub grid_articulos_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_articulos.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            enviar_id(GridView1.GetRowCellValue(rowhandle, "id_articulo").ToString())
        End If
    End Sub
End Class