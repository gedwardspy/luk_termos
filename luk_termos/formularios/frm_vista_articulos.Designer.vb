<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vista_articulos
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Descripcion = New DevExpress.XtraEditors.TextEdit()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grid_articulos = New DevExpress.XtraGrid.GridControl()
        Me.col_id_articulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.txt_Descripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(130, 16)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Descripcion de Articulo"
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.Location = New System.Drawing.Point(12, 31)
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_Descripcion.Properties.Appearance.Options.UseFont = True
        Me.txt_Descripcion.Size = New System.Drawing.Size(279, 24)
        Me.txt_Descripcion.TabIndex = 0
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.SeparatorControl1.LineThickness = 5
        Me.SeparatorControl1.Location = New System.Drawing.Point(12, 59)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(365, 23)
        Me.SeparatorControl1.TabIndex = 3
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_articulo, Me.col_descripcion, Me.col_codigo})
        Me.GridView1.GridControl = Me.grid_articulos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'grid_articulos
        '
        Me.grid_articulos.Location = New System.Drawing.Point(12, 85)
        Me.grid_articulos.MainView = Me.GridView1
        Me.grid_articulos.Name = "grid_articulos"
        Me.grid_articulos.Size = New System.Drawing.Size(365, 322)
        Me.grid_articulos.TabIndex = 1
        Me.grid_articulos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'col_id_articulo
        '
        Me.col_id_articulo.Caption = "id articulo"
        Me.col_id_articulo.FieldName = "id_articulo"
        Me.col_id_articulo.Name = "col_id_articulo"
        '
        'col_descripcion
        '
        Me.col_descripcion.Caption = "Descripcion"
        Me.col_descripcion.FieldName = "nombre"
        Me.col_descripcion.Name = "col_descripcion"
        Me.col_descripcion.Visible = True
        Me.col_descripcion.VisibleIndex = 1
        '
        'col_codigo
        '
        Me.col_codigo.AppearanceCell.Options.UseTextOptions = True
        Me.col_codigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_codigo.AppearanceHeader.Options.UseTextOptions = True
        Me.col_codigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_codigo.Caption = "Codigo"
        Me.col_codigo.FieldName = "codigo_articulo"
        Me.col_codigo.Name = "col_codigo"
        Me.col_codigo.Visible = True
        Me.col_codigo.VisibleIndex = 1
        Me.col_codigo.Width = 104
        '
        'frm_vista_articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 419)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.txt_Descripcion)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_articulos)
        Me.Name = "frm_vista_articulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<<Busqueda de Articulos>>"
        CType(Me.txt_Descripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Descripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents grid_articulos As DevExpress.XtraGrid.GridControl
    Friend WithEvents col_id_articulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_codigo As DevExpress.XtraGrid.Columns.GridColumn
End Class
