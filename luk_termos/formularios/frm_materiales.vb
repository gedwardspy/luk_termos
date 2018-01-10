Imports DevExpress.XtraEditors

Public Class frm_materiales

    Private dt_materiales As New DataTable
    Private Const TITULO_MSJ = "<<Registro de Materias Primas>>"

    Private ID_MATERIA As Integer = 0
    Private NOMBRE As String = ""
    Private CODIGO As String = ""

    Dim materiales As New func_materiales()
    Dim util As New utilidades()

    Private Sub frm_materiales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desabilitar()
        listar()
    End Sub
    Private Sub desabilitar()
        txt_nombre.Enabled = False
        txt_codigo.Enabled = False
        btn_confirmar.Enabled = False

        btn_nuevo.Focus()
    End Sub

    Private Sub nuevo()
        txt_nombre.Enabled = True
        txt_codigo.Enabled = True
        btn_confirmar.Enabled = True

        txt_nombre.Text = ""

        txt_codigo.Text = ""

        txt_nombre.Focus()
    End Sub

    Private Sub listar()
        dt_materiales.Clear()
        dt_materiales = materiales.listar("SELECT * FROM materiales ORDER BY fecha_cre DESC, fecha_mod DESC")

        grid_materiales.DataSource = dt_materiales
    End Sub

    Private Sub insertar_actualizar()
        NOMBRE = txt_nombre.Text
        CODIGO = txt_codigo.Text

        If NOMBRE = "" Then
            util.mensajes("Ingrese nombre para Materia Prima", TITULO_MSJ)
            txt_nombre.Focus()
        ElseIf CODIGO = "" Then
            util.mensajes("Ingrese codigo para Materia Prima", TITULO_MSJ)
            txt_codigo.Focus()
        Else
            If ID_MATERIA <= 0 Then
                If materiales.insertar(NOMBRE, CODIGO, 1) Then
                    util.mensajes("Materia Prima Registrada", TITULO_MSJ)
                    desabilitar()
                    nuevo()
                    btn_nuevo.Focus()
                Else
                    util.mensajes("Materia Prima no Registrada", TITULO_MSJ)
                End If
            Else
                If materiales.actualizar(NOMBRE, CODIGO, 1, ID_MATERIA) Then
                    util.mensajes("Materia Prima Modificada", TITULO_MSJ)
                    desabilitar()
                    nuevo()
                    btn_nuevo.Focus()
                Else
                    util.mensajes("Materia Prima no Modificada", TITULO_MSJ)
                End If
            End If

            listar()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        nuevo()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Dim result As DialogResult = XtraMessageBox.Show("Deseas confirmas la operacion?", TITULO_MSJ, MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            insertar_actualizar()
        Else
            btn_confirmar.Focus()
        End If
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_codigo.Focus()
        End If
    End Sub

    Private Sub txt_codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_confirmar.Focus()
        End If
    End Sub

    Private Sub grid_materiales_Click(sender As Object, e As EventArgs) Handles grid_materiales.Click
        nuevo()

        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        ID_MATERIA = CInt(GridView1.GetRowCellValue(rowhandle, "id_material").ToString)
        txt_nombre.Text = GridView1.GetRowCellValue(rowhandle, "nombre").ToString
        txt_codigo.Text = GridView1.GetRowCellValue(rowhandle, "codigo").ToString

        grid_materiales.Focus()
    End Sub

    Private Sub grid_materiales_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_materiales.KeyDown
        If e.KeyCode = Keys.Enter Then
            nuevo()

            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            ID_MATERIA = CInt(GridView1.GetRowCellValue(rowhandle, "id_material").ToString())
            txt_nombre.Text = GridView1.GetRowCellValue(rowhandle, "nombre").ToString()
            txt_codigo.Text = GridView1.GetRowCellValue(rowhandle, "codigo").ToString()

            grid_materiales.Focus()
        End If
    End Sub
End Class