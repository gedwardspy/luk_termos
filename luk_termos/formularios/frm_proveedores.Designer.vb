<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_proveedores))
        Me.chk_activo = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_email = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_telefono = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ruc = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_proveedores = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GirdColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_modificar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_nombre_proveedor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_codigo = New DevExpress.XtraEditors.TextEdit()
        Me.btn_agregar = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.chk_activo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_email.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_telefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ruc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombre_proveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_codigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chk_activo
        '
        Me.chk_activo.Enabled = False
        Me.chk_activo.Location = New System.Drawing.Point(460, 283)
        Me.chk_activo.Name = "chk_activo"
        Me.chk_activo.Properties.Caption = "Activo"
        Me.chk_activo.Size = New System.Drawing.Size(69, 19)
        Me.chk_activo.TabIndex = 5
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(621, 334)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(74, 25)
        Me.btn_cancelar.TabIndex = 8
        Me.btn_cancelar.Text = "Cancelar"
        '
        'txt_email
        '
        Me.txt_email.Enabled = False
        Me.txt_email.Location = New System.Drawing.Point(457, 247)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_email.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_email.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_email.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_email.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_email.Size = New System.Drawing.Size(180, 20)
        Me.txt_email.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(457, 228)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl4.TabIndex = 20
        Me.LabelControl4.Text = "e-mail"
        '
        'txt_telefono
        '
        Me.txt_telefono.Enabled = False
        Me.txt_telefono.Location = New System.Drawing.Point(457, 197)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_telefono.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_telefono.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_telefono.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_telefono.Size = New System.Drawing.Size(180, 20)
        Me.txt_telefono.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(457, 179)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl3.TabIndex = 18
        Me.LabelControl3.Text = "Teléfono"
        '
        'txt_ruc
        '
        Me.txt_ruc.Enabled = False
        Me.txt_ruc.Location = New System.Drawing.Point(457, 146)
        Me.txt_ruc.Name = "txt_ruc"
        Me.txt_ruc.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_ruc.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_ruc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_ruc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_ruc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ruc.Size = New System.Drawing.Size(180, 20)
        Me.txt_ruc.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(457, 128)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "R.U.C."
        '
        'grid_proveedores
        '
        Me.grid_proveedores.Location = New System.Drawing.Point(12, 12)
        Me.grid_proveedores.MainView = Me.GridView1
        Me.grid_proveedores.Name = "grid_proveedores"
        Me.grid_proveedores.Size = New System.Drawing.Size(426, 457)
        Me.grid_proveedores.TabIndex = 15
        Me.grid_proveedores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.SteelBlue
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.SteelBlue
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GirdColumn5, Me.GridColumn5})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.grid_proveedores
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsPrint.RtfPageHeader = resources.GetString("GridView1.OptionsPrint.RtfPageHeader")
        Me.GridView1.OptionsPrint.RtfReportFooter = resources.GetString("GridView1.OptionsPrint.RtfReportFooter")
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Nombre del Proveedor"
        Me.GridColumn1.FieldName = "nombre"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 160
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "R.U.C."
        Me.GridColumn2.FieldName = "ruc"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 73
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Teléfono"
        Me.GridColumn3.FieldName = "telefono"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "e-mail"
        Me.GridColumn4.FieldName = "correo"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GirdColumn5
        '
        Me.GirdColumn5.Caption = "identificador"
        Me.GirdColumn5.FieldName = "id_proveedor"
        Me.GirdColumn5.Name = "GirdColumn5"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Activo"
        Me.GridColumn5.FieldName = "activo"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(457, 83)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl1.TabIndex = 14
        Me.LabelControl1.Text = "Nombre del Proveedor"
        '
        'btn_modificar
        '
        Me.btn_modificar.Image = CType(resources.GetObject("btn_modificar.Image"), System.Drawing.Image)
        Me.btn_modificar.Location = New System.Drawing.Point(539, 334)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(74, 25)
        Me.btn_modificar.TabIndex = 7
        Me.btn_modificar.Text = "Modificar"
        '
        'txt_nombre_proveedor
        '
        Me.txt_nombre_proveedor.Enabled = False
        Me.txt_nombre_proveedor.Location = New System.Drawing.Point(457, 99)
        Me.txt_nombre_proveedor.Name = "txt_nombre_proveedor"
        Me.txt_nombre_proveedor.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_nombre_proveedor.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_nombre_proveedor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_nombre_proveedor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nombre_proveedor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre_proveedor.Properties.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far
        Me.txt_nombre_proveedor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_nombre_proveedor.Size = New System.Drawing.Size(180, 20)
        Me.txt_nombre_proveedor.TabIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(457, 41)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl5.TabIndex = 25
        Me.LabelControl5.Text = "Código"
        '
        'txt_codigo
        '
        Me.txt_codigo.Enabled = False
        Me.txt_codigo.Location = New System.Drawing.Point(457, 57)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_codigo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_codigo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_codigo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_codigo.Size = New System.Drawing.Size(72, 20)
        Me.txt_codigo.TabIndex = 0
        '
        'btn_agregar
        '
        Me.btn_agregar.Image = CType(resources.GetObject("btn_agregar.Image"), System.Drawing.Image)
        Me.btn_agregar.Location = New System.Drawing.Point(457, 334)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(76, 25)
        Me.btn_agregar.TabIndex = 6
        Me.btn_agregar.Text = "Agregar"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(357, 442)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(73, 23)
        Me.SimpleButton1.TabIndex = 26
        Me.SimpleButton1.Text = "Imprimir"
        '
        'frm_proveedores
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Appearance.ForeColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 480)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.chk_activo)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txt_ruc)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.grid_proveedores)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.txt_nombre_proveedor)
        Me.Name = "frm_proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedores"
        CType(Me.chk_activo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_email.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_telefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ruc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombre_proveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_codigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chk_activo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_email As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_telefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ruc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_proveedores As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_modificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_nombre_proveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_codigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_agregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GirdColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
