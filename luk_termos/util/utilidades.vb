Imports DevExpress
Imports DevExpress.XtraEditors

Public Class utilidades

    Public Function fecha() As String
        Return Now.ToString("dd/MM/yyyy")
    End Function

    Public Sub mensajes(ByVal mensaje As String, ByVal titulo As String)
        XtraEditors.XtraMessageBox.AllowCustomLookAndFeel = True
        XtraEditors.XtraMessageBox.Show(mensaje, titulo, Utils.DefaultBoolean.Default)
    End Sub

    Public Function msj_confirmacion(ByVal mensaje As String, ByVal titulo As String) As Boolean
        Dim result As DialogResult = XtraMessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo)
        Return result = DialogResult.Yes
    End Function


End Class
