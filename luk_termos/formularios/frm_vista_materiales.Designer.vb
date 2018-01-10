<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vista_materiales
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
        Me.txt_Descripcion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_materiales = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_material = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.txt_Descripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_materiales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.Location = New System.Drawing.Point(23, 44)
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_Descripcion.Properties.Appearance.Options.UseFont = True
        Me.txt_Descripcion.Size = New System.Drawing.Size(279, 24)
        Me.txt_Descripcion.TabIndex = 6
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(23, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(116, 16)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Nombre del Material"
        '
        'grid_materiales
        '
        Me.grid_materiales.Location = New System.Drawing.Point(23, 98)
        Me.grid_materiales.MainView = Me.GridView1
        Me.grid_materiales.Name = "grid_materiales"
        Me.grid_materiales.Size = New System.Drawing.Size(365, 322)
        Me.grid_materiales.TabIndex = 7
        Me.grid_materiales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_material, Me.col_descripcion, Me.col_codigo})
        Me.GridView1.GridControl = Me.grid_materiales
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_id_material
        '
        Me.col_id_material.Caption = "Id Material"
        Me.col_id_material.FieldName = "id_material"
        Me.col_id_material.Name = "col_id_material"
        '
        'col_descripcion
        '
        Me.col_descripcion.Caption = "Descripcion"
        Me.col_descripcion.FieldName = "nombre"
        Me.col_descripcion.Name = "col_descripcion"
        Me.col_descripcion.Visible = True
        Me.col_descripcion.VisibleIndex = 0
        Me.col_descripcion.Width = 226
        '
        'col_codigo
        '
        Me.col_codigo.AppearanceCell.Options.UseTextOptions = True
        Me.col_codigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_codigo.AppearanceHeader.Options.UseTextOptions = True
        Me.col_codigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_codigo.Caption = "Codigo"
        Me.col_codigo.FieldName = "codigo"
        Me.col_codigo.Name = "col_codigo"
        Me.col_codigo.Visible = True
        Me.col_codigo.VisibleIndex = 1
        Me.col_codigo.Width = 121
        '
        'frm_vista_materiales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 442)
        Me.Controls.Add(Me.txt_Descripcion)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_materiales)
        Me.Name = "frm_vista_materiales"
        Me.Text = "<<Busqueda de Materiales>>"
        CType(Me.txt_Descripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_materiales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Descripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_materiales As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_material As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_codigo As DevExpress.XtraGrid.Columns.GridColumn
End Class
