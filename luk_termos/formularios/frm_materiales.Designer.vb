<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_materiales
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
        Me.grid_materiales = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_material = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_nuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_codigo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nombre = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grid_materiales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_codigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grid_materiales)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 190)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(574, 258)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Listado de Materias Primas"
        '
        'grid_materiales
        '
        Me.grid_materiales.Location = New System.Drawing.Point(14, 32)
        Me.grid_materiales.MainView = Me.GridView1
        Me.grid_materiales.Name = "grid_materiales"
        Me.grid_materiales.Size = New System.Drawing.Size(544, 221)
        Me.grid_materiales.TabIndex = 0
        Me.grid_materiales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_nombre, Me.col_codigo, Me.col_id_material})
        Me.GridView1.GridControl = Me.grid_materiales
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_nombre
        '
        Me.col_nombre.Caption = "Nombre de Materia Prima"
        Me.col_nombre.FieldName = "nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.Visible = True
        Me.col_nombre.VisibleIndex = 0
        Me.col_nombre.Width = 313
        '
        'col_codigo
        '
        Me.col_codigo.AppearanceCell.Options.UseTextOptions = True
        Me.col_codigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_codigo.AppearanceHeader.Options.UseTextOptions = True
        Me.col_codigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_codigo.Caption = "Codigo"
        Me.col_codigo.DisplayFormat.FormatString = "#,#"
        Me.col_codigo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_codigo.FieldName = "codigo"
        Me.col_codigo.Name = "col_codigo"
        Me.col_codigo.Visible = True
        Me.col_codigo.VisibleIndex = 1
        Me.col_codigo.Width = 193
        '
        'col_id_material
        '
        Me.col_id_material.Caption = "Id Material"
        Me.col_id_material.FieldName = "id_material"
        Me.col_id_material.Name = "col_id_material"
        Me.col_id_material.Width = 20
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btn_confirmar)
        Me.GroupControl1.Controls.Add(Me.btn_nuevo)
        Me.GroupControl1.Controls.Add(Me.txt_codigo)
        Me.GroupControl1.Controls.Add(Me.txt_nombre)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(580, 163)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = " Datos de Materia Prima"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Location = New System.Drawing.Point(403, 96)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(94, 33)
        Me.btn_confirmar.TabIndex = 3
        Me.btn_confirmar.Text = " Confirmar"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(403, 42)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(94, 33)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = " Nuevo"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(106, 122)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Properties.Mask.EditMask = "n0"
        Me.txt_codigo.Size = New System.Drawing.Size(205, 20)
        Me.txt_codigo.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(106, 40)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_nombre.Size = New System.Drawing.Size(205, 66)
        Me.txt_nombre.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(63, 125)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Codigo:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Location = New System.Drawing.Point(42, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Descripcion:"
        '
        'frm_materiales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 473)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frm_materiales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<<Registro de Materiales>>"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grid_materiales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txt_codigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grid_materiales As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_material As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_nuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_codigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nombre As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
