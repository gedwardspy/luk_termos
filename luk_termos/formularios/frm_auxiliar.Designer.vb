<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_auxiliar
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
        Me.ButtonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonEdit1
        '
        Me.ButtonEdit1.Location = New System.Drawing.Point(332, 184)
        Me.ButtonEdit1.Name = "ButtonEdit1"
        Me.ButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ButtonEdit1.Size = New System.Drawing.Size(100, 20)
        Me.ButtonEdit1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(170, 43)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "ESTO ES UNA PRUEBA"
        '
        'frm_auxiliar
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 294)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ButtonEdit1)
        Me.Name = "frm_auxiliar"
        Me.Text = "frm_auxiliar"
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonEdit1 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
