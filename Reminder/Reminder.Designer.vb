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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reminder))
        TabControl1 = New TabControl()
        tabHome = New TabPage()
        btnAddEvent = New Button()
        Label2 = New Label()
        Label1 = New Label()
        tabSettings = New TabPage()
        Button1 = New Button()
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
        TabControl1.Size = New Size(1013, 671)
        TabControl1.TabIndex = 0
        ' 
        ' tabHome
        ' 
        tabHome.Controls.Add(btnAddEvent)
        tabHome.Controls.Add(Label2)
        tabHome.Controls.Add(Label1)
        tabHome.Location = New Point(4, 34)
        tabHome.Name = "tabHome"
        tabHome.Padding = New Padding(3)
        tabHome.Size = New Size(1005, 633)
        tabHome.TabIndex = 0
        tabHome.Text = "Home"
        tabHome.UseVisualStyleBackColor = True
        ' 
        ' btnAddEvent
        ' 
        btnAddEvent.Image = CType(resources.GetObject("btnAddEvent.Image"), Image)
        btnAddEvent.ImageAlign = ContentAlignment.MiddleLeft
        btnAddEvent.Location = New Point(858, 17)
        btnAddEvent.Name = "btnAddEvent"
        btnAddEvent.Size = New Size(124, 48)
        btnAddEvent.TabIndex = 2
        btnAddEvent.Text = "Add Event"
        btnAddEvent.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAddEvent.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Thistle
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(26, 310)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 38)
        Label2.TabIndex = 1
        Label2.Text = "Event"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Thistle
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(14, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(245, 38)
        Label1.TabIndex = 0
        Label1.Text = "Up Coming Event"
        ' 
        ' tabSettings
        ' 
        tabSettings.Controls.Add(Button1)
        tabSettings.Location = New Point(4, 34)
        tabSettings.Name = "tabSettings"
        tabSettings.Padding = New Padding(3)
        tabSettings.Size = New Size(1005, 633)
        tabSettings.TabIndex = 1
        tabSettings.Text = "Settings"
        tabSettings.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(6, 593)
        Button1.Name = "Button1"
        Button1.Size = New Size(211, 34)
        Button1.TabIndex = 0
        Button1.Text = "Log out"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Reminder
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1014, 670)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddEvent As Button
    Friend WithEvents Label2 As Label
End Class
