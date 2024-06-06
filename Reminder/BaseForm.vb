Public Class BaseForm
    Inherits Form

    Public Sub New()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
    End Sub
End Class
