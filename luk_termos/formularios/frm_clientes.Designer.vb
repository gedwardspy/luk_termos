<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_clientes
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
        Me.grid_clientes = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_cliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_nombres = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_apellidos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_nro_documento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_telefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_ciudad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_direccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_nuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_direccion = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ciudad = New DevExpress.XtraEditors.TextEdit()
        Me.txt_telefono = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nro_documeto = New DevExpress.XtraEditors.TextEdit()
        Me.txt_apellidos = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nombres = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grid_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_direccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ciudad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_telefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nro_documeto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_apellidos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grid_clientes)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 199)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(823, 296)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Listado de Clientes"
        '
        'grid_clientes
        '
        Me.grid_clientes.Location = New System.Drawing.Point(10, 28)
        Me.grid_clientes.MainView = Me.GridView1
        Me.grid_clientes.Name = "grid_clientes"
        Me.grid_clientes.Size = New System.Drawing.Size(803, 254)
        Me.grid_clientes.TabIndex = 0
        Me.grid_clientes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.SelectedRow.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_cliente, Me.col_nombres, Me.col_apellidos, Me.col_nro_documento, Me.col_telefono, Me.col_ciudad, Me.col_direccion})
        Me.GridView1.GridControl = Me.grid_clientes
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_id_cliente
        '
        Me.col_id_cliente.AppearanceCell.Options.UseTextOptions = True
        Me.col_id_cliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_id_cliente.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id_cliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_id_cliente.Caption = "Id Cliente"
        Me.col_id_cliente.FieldName = "id_cliente"
        Me.col_id_cliente.Name = "col_id_cliente"
        Me.col_id_cliente.Width = 20
        '
        'col_nombres
        '
        Me.col_nombres.AppearanceCell.Options.UseTextOptions = True
        Me.col_nombres.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_nombres.AppearanceHeader.Options.UseTextOptions = True
        Me.col_nombres.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_nombres.Caption = "Nombre/s"
        Me.col_nombres.FieldName = "nombres"
        Me.col_nombres.Name = "col_nombres"
        Me.col_nombres.Visible = True
        Me.col_nombres.VisibleIndex = 0
        Me.col_nombres.Width = 185
        '
        'col_apellidos
        '
        Me.col_apellidos.AppearanceCell.Options.UseTextOptions = True
        Me.col_apellidos.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_apellidos.AppearanceHeader.Options.UseTextOptions = True
        Me.col_apellidos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_apellidos.Caption = "Apellido/s"
        Me.col_apellidos.FieldName = "apellidos"
        Me.col_apellidos.Name = "col_apellidos"
        Me.col_apellidos.Visible = True
        Me.col_apellidos.VisibleIndex = 1
        Me.col_apellidos.Width = 177
        '
        'col_nro_documento
        '
        Me.col_nro_documento.AppearanceCell.Options.UseTextOptions = True
        Me.col_nro_documento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_nro_documento.AppearanceHeader.Options.UseTextOptions = True
        Me.col_nro_documento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_nro_documento.Caption = "Nro. Documento"
        Me.col_nro_documento.FieldName = "numero_documento"
        Me.col_nro_documento.Name = "col_nro_documento"
        Me.col_nro_documento.Visible = True
        Me.col_nro_documento.VisibleIndex = 2
        Me.col_nro_documento.Width = 97
        '
        'col_telefono
        '
        Me.col_telefono.AppearanceCell.Options.UseTextOptions = True
        Me.col_telefono.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_telefono.AppearanceHeader.Options.UseTextOptions = True
        Me.col_telefono.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_telefono.Caption = "Telefono"
        Me.col_telefono.FieldName = "telefono"
        Me.col_telefono.Name = "col_telefono"
        Me.col_telefono.Visible = True
        Me.col_telefono.VisibleIndex = 3
        Me.col_telefono.Width = 97
        '
        'col_ciudad
        '
        Me.col_ciudad.AppearanceCell.Options.UseTextOptions = True
        Me.col_ciudad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_ciudad.AppearanceHeader.Options.UseTextOptions = True
        Me.col_ciudad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_ciudad.Caption = "Ciudad"
        Me.col_ciudad.FieldName = "ciudad"
        Me.col_ciudad.Name = "col_ciudad"
        Me.col_ciudad.Visible = True
        Me.col_ciudad.VisibleIndex = 4
        Me.col_ciudad.Width = 97
        '
        'col_direccion
        '
        Me.col_direccion.AppearanceCell.Options.UseTextOptions = True
        Me.col_direccion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_direccion.AppearanceHeader.Options.UseTextOptions = True
        Me.col_direccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_direccion.Caption = "Direccion"
        Me.col_direccion.FieldName = "direccion"
        Me.col_direccion.Name = "col_direccion"
        Me.col_direccion.Visible = True
        Me.col_direccion.VisibleIndex = 5
        Me.col_direccion.Width = 97
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btn_confirmar)
        Me.GroupControl1.Controls.Add(Me.btn_nuevo)
        Me.GroupControl1.Controls.Add(Me.txt_direccion)
        Me.GroupControl1.Controls.Add(Me.txt_ciudad)
        Me.GroupControl1.Controls.Add(Me.txt_telefono)
        Me.GroupControl1.Controls.Add(Me.txt_nro_documeto)
        Me.GroupControl1.Controls.Add(Me.txt_apellidos)
        Me.GroupControl1.Controls.Add(Me.txt_nombres)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(823, 181)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Datos del Cliente"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_confirmar.Appearance.Options.UseForeColor = True
        Me.btn_confirmar.Location = New System.Drawing.Point(688, 95)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(93, 35)
        Me.btn_confirmar.TabIndex = 7
        Me.btn_confirmar.Text = "Confirmar"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(688, 51)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(93, 35)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = "Nuevo"
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(414, 120)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(186, 20)
        Me.txt_direccion.TabIndex = 6
        '
        'txt_ciudad
        '
        Me.txt_ciudad.Location = New System.Drawing.Point(414, 80)
        Me.txt_ciudad.Name = "txt_ciudad"
        Me.txt_ciudad.Size = New System.Drawing.Size(186, 20)
        Me.txt_ciudad.TabIndex = 5
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(414, 40)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(186, 20)
        Me.txt_telefono.TabIndex = 4
        '
        'txt_nro_documeto
        '
        Me.txt_nro_documeto.Location = New System.Drawing.Point(132, 120)
        Me.txt_nro_documeto.Name = "txt_nro_documeto"
        Me.txt_nro_documeto.Properties.Mask.EditMask = "n0"
        Me.txt_nro_documeto.Size = New System.Drawing.Size(186, 20)
        Me.txt_nro_documeto.TabIndex = 3
        '
        'txt_apellidos
        '
        Me.txt_apellidos.Location = New System.Drawing.Point(132, 80)
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Size = New System.Drawing.Size(186, 20)
        Me.txt_apellidos.TabIndex = 2
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(132, 40)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(186, 20)
        Me.txt_nombres.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(371, 83)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Ciudad:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(358, 123)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = " Direccion:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(41, 123)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = " Nro. Documento:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(362, 43)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Telefono:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(73, 83)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = " Apellido/s:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(73, 43)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = " Nombre/s:"
        '
        'frm_clientes
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 512)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frm_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<<Registro de Clientes>>"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grid_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txt_direccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ciudad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_telefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nro_documeto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_apellidos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grid_clientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_cliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nombres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_apellidos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nro_documento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_telefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_ciudad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_direccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_nuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_direccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ciudad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_telefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nro_documeto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_apellidos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
