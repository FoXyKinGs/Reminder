<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changePassword
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
        btnBack = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtOldPassword = New TextBox()
        txtNewPassword = New TextBox()
        txtConfirmNewPassword = New TextBox()
        btnChangePassword = New Button()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(25, 21)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(112, 32)
        btnBack.TabIndex = 0
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 25)
        Label1.TabIndex = 1
        Label1.Text = "Old Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 25)
        Label2.TabIndex = 2
        Label2.Text = "New Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(156, 25)
        Label3.TabIndex = 3
        Label3.Text = "Confirm Password"
        ' 
        ' txtOldPassword
        ' 
        txtOldPassword.Location = New Point(201, 71)
        txtOldPassword.Name = "txtOldPassword"
        txtOldPassword.PasswordChar = "*"c
        txtOldPassword.Size = New Size(424, 31)
        txtOldPassword.TabIndex = 4
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Location = New Point(201, 124)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.PasswordChar = "*"c
        txtNewPassword.Size = New Size(424, 31)
        txtNewPassword.TabIndex = 5
        ' 
        ' txtConfirmNewPassword
        ' 
        txtConfirmNewPassword.Location = New Point(201, 175)
        txtConfirmNewPassword.Name = "txtConfirmNewPassword"
        txtConfirmNewPassword.PasswordChar = "*"c
        txtConfirmNewPassword.Size = New Size(424, 31)
        txtConfirmNewPassword.TabIndex = 6
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.Cursor = Cursors.Hand
        btnChangePassword.Location = New Point(510, 225)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New Size(112, 34)
        btnChangePassword.TabIndex = 7
        btnChangePassword.Text = "Change!"
        btnChangePassword.UseVisualStyleBackColor = True
        ' 
        ' ChangePassword
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(653, 278)
        Controls.Add(btnChangePassword)
        Controls.Add(txtConfirmNewPassword)
        Controls.Add(txtNewPassword)
        Controls.Add(txtOldPassword)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        Name = "ChangePassword"
        Text = "Change Password"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOldPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtConfirmNewPassword As TextBox
    Friend WithEvents btnChangePassword As Button
End Class
