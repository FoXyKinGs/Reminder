<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingScene
    Inherits BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pbLoading = New ProgressBar()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' pbLoading
        ' 
        pbLoading.Location = New Point(12, 152)
        pbLoading.Name = "pbLoading"
        pbLoading.Size = New Size(511, 34)
        pbLoading.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 25)
        Label1.TabIndex = 1
        Label1.Text = "Loading Fetching Information...."
        ' 
        ' LoadingScene
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(535, 200)
        Controls.Add(Label1)
        Controls.Add(pbLoading)
        Name = "LoadingScene"
        Text = "Please Wait"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbLoading As ProgressBar
    Friend WithEvents Label1 As Label
End Class
