<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_articulos
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_agregar_material = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_articulos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_material = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_nombre_material = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_txt_cantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lbl_mensaje = New DevExpress.XtraEditors.LabelControl()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_buscar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_comentario = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_precio_venta = New DevExpress.XtraEditors.TextEdit()
        Me.txt_costo_unitario = New DevExpress.XtraEditors.TextEdit()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_nuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.cbo_tipo_articulo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_codigo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nombre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grid_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col_txt_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_comentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_precio_venta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_costo_unitario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_tipo_articulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_codigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.btn_agregar_material)
        Me.GroupControl2.Controls.Add(Me.grid_articulos)
        Me.GroupControl2.Location = New System.Drawing.Point(39, 210)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(866, 335)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Materiales del Articulo"
        '
        'btn_agregar_material
        '
        Me.btn_agregar_material.Location = New System.Drawing.Point(749, 46)
        Me.btn_agregar_material.Name = "btn_agregar_material"
        Me.btn_agregar_material.Size = New System.Drawing.Size(74, 22)
        Me.btn_agregar_material.TabIndex = 19
        Me.btn_agregar_material.Text = "Agregar Mat."
        '
        'grid_articulos
        '
        Me.grid_articulos.Location = New System.Drawing.Point(5, 33)
        Me.grid_articulos.MainView = Me.GridView1
        Me.grid_articulos.Name = "grid_articulos"
        Me.grid_articulos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.col_txt_cantidad})
        Me.grid_articulos.Size = New System.Drawing.Size(856, 297)
        Me.grid_articulos.TabIndex = 0
        Me.grid_articulos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_material, Me.col_nombre_material, Me.col_cantidad})
        Me.GridView1.GridControl = Me.grid_articulos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AllowFindPanel = False
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_id_material
        '
        Me.col_id_material.Caption = "Id Material"
        Me.col_id_material.FieldName = "id_material"
        Me.col_id_material.Name = "col_id_material"
        Me.col_id_material.Width = 61
        '
        'col_nombre_material
        '
        Me.col_nombre_material.Caption = "Nombre Material"
        Me.col_nombre_material.FieldName = "nombre"
        Me.col_nombre_material.Name = "col_nombre_material"
        Me.col_nombre_material.Visible = True
        Me.col_nombre_material.VisibleIndex = 0
        Me.col_nombre_material.Width = 326
        '
        'col_cantidad
        '
        Me.col_cantidad.AppearanceCell.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cantidad.Caption = "Cantidad a Utilizar"
        Me.col_cantidad.ColumnEdit = Me.col_txt_cantidad
        Me.col_cantidad.DisplayFormat.FormatString = "0.00"
        Me.col_cantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.col_cantidad.FieldName = "cantidad"
        Me.col_cantidad.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.Visible = True
        Me.col_cantidad.VisibleIndex = 1
        Me.col_cantidad.Width = 207
        '
        'col_txt_cantidad
        '
        Me.col_txt_cantidad.AutoHeight = False
        Me.col_txt_cantidad.DisplayFormat.FormatString = "0.0"
        Me.col_txt_cantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_txt_cantidad.Name = "col_txt_cantidad"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lbl_mensaje)
        Me.GroupControl1.Controls.Add(Me.btn_cancelar)
        Me.GroupControl1.Controls.Add(Me.btn_buscar)
        Me.GroupControl1.Controls.Add(Me.txt_comentario)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txt_precio_venta)
        Me.GroupControl1.Controls.Add(Me.txt_costo_unitario)
        Me.GroupControl1.Controls.Add(Me.btn_confirmar)
        Me.GroupControl1.Controls.Add(Me.btn_nuevo)
        Me.GroupControl1.Controls.Add(Me.cbo_tipo_articulo)
        Me.GroupControl1.Controls.Add(Me.txt_codigo)
        Me.GroupControl1.Controls.Add(Me.txt_nombre)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(39, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(866, 192)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Datos del Articulo"
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_mensaje.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_mensaje.Location = New System.Drawing.Point(443, 156)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(256, 13)
        Me.lbl_mensaje.TabIndex = 19
        Me.lbl_mensaje.Text = "Agrege o Actualize los materiales del Articulo"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(731, 100)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(92, 28)
        Me.btn_cancelar.TabIndex = 18
        Me.btn_cancelar.Text = "Cancelar"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(305, 28)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(25, 22)
        Me.btn_buscar.TabIndex = 17
        Me.btn_buscar.Text = "...."
        '
        'txt_comentario
        '
        Me.txt_comentario.Location = New System.Drawing.Point(101, 67)
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.Size = New System.Drawing.Size(229, 66)
        Me.txt_comentario.TabIndex = 2
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(37, 69)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl7.TabIndex = 16
        Me.LabelControl7.Text = " Comentario:"
        '
        'txt_precio_venta
        '
        Me.txt_precio_venta.Location = New System.Drawing.Point(458, 66)
        Me.txt_precio_venta.Name = "txt_precio_venta"
        Me.txt_precio_venta.Properties.Mask.EditMask = "n0"
        Me.txt_precio_venta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_precio_venta.Size = New System.Drawing.Size(229, 20)
        Me.txt_precio_venta.TabIndex = 6
        '
        'txt_costo_unitario
        '
        Me.txt_costo_unitario.Location = New System.Drawing.Point(458, 29)
        Me.txt_costo_unitario.Name = "txt_costo_unitario"
        Me.txt_costo_unitario.Properties.Mask.EditMask = "n0"
        Me.txt_costo_unitario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_costo_unitario.Size = New System.Drawing.Size(229, 20)
        Me.txt_costo_unitario.TabIndex = 5
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Location = New System.Drawing.Point(731, 66)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(92, 28)
        Me.btn_confirmar.TabIndex = 8
        Me.btn_confirmar.Text = "Confirmar"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(731, 31)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(92, 28)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = " Nuevo"
        '
        'cbo_tipo_articulo
        '
        Me.cbo_tipo_articulo.EditValue = "Seleccione tipo  de Articulo"
        Me.cbo_tipo_articulo.Location = New System.Drawing.Point(458, 104)
        Me.cbo_tipo_articulo.Name = "cbo_tipo_articulo"
        Me.cbo_tipo_articulo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_tipo_articulo.Properties.Items.AddRange(New Object() {"Seleccione tipo  de Articulo", "Articulo Final", "Personalizado"})
        Me.cbo_tipo_articulo.Size = New System.Drawing.Size(229, 20)
        Me.cbo_tipo_articulo.TabIndex = 7
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(101, 149)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(229, 20)
        Me.txt_codigo.TabIndex = 3
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(101, 29)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(198, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(371, 107)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = " Tipo de Articulo:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(385, 69)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = " Precio Venta:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(377, 32)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = " Costo Unitario:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(55, 152)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = " Codigo:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(54, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nombre:"
        '
        'frm_articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 560)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frm_articulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<<Registro de Articulos>>"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grid_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.col_txt_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txt_comentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_precio_venta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_costo_unitario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_tipo_articulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_codigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grid_articulos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_material As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nombre_material As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_comentario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_precio_venta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_costo_unitario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_nuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbo_tipo_articulo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_codigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_txt_cantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_buscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_agregar_material As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_mensaje As DevExpress.XtraEditors.LabelControl
End Class
