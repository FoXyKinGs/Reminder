<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reminder
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
        TabControl1 = New TabControl()
        tabHome = New TabPage()
        tabSettings = New TabPage()
        Button1 = New Button()
        Label1 = New Label()
        TabControl1.SuspendLayout()
        tabHome.SuspendLayout()
        tabSettings.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabHome)
        TabControl1.Controls.Add(tabSettings)
        TabControl1.Location = New Point(1, 1)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(801, 452)
        TabControl1.TabIndex = 0
        ' 
        ' tabHome
        ' 
        tabHome.Controls.Add(Label1)
        tabHome.Location = New Point(4, 34)
        tabHome.Name = "tabHome"
        tabHome.Padding = New Padding(3)
        tabHome.Size = New Size(793, 414)
        tabHome.TabIndex = 0
        tabHome.Text = "Home"
        tabHome.UseVisualStyleBackColor = True
        ' 
        ' tabSettings
        ' 
        tabSettings.Controls.Add(Button1)
        tabSettings.Location = New Point(4, 34)
        tabSettings.Name = "tabSettings"
        tabSettings.Padding = New Padding(3)
        tabSettings.Size = New Size(793, 414)
        tabSettings.TabIndex = 1
        tabSettings.Text = "Settings"
        tabSettings.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(16, 369)
        Button1.Name = "Button1"
        Button1.Size = New Size(211, 34)
        Button1.TabIndex = 0
        Button1.Text = "Kembali Ke Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(311, 177)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 25)
        Label1.TabIndex = 0
        Label1.Text = "Ini Halaman Utama"
        ' 
        ' Reminder
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Name = "Reminder"
        Text = "Reminder"
        TabControl1.ResumeLayout(False)
        tabHome.ResumeLayout(False)
        tabHome.PerformLayout()
        tabSettings.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabHome As TabPage
    Friend WithEvents tabSettings As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
