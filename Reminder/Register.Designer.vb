<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        btnCreate = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' btnCreate
        ' 
        btnCreate.Cursor = Cursors.Hand
        btnCreate.Location = New Point(370, 278)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(163, 34)
        btnCreate.TabIndex = 0
        btnCreate.Text = "Create One!"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 1
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 2
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 25)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(156, 25)
        Label4.TabIndex = 4
        Label4.Text = "Confirm Password"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(202, 28)
        txtName.Name = "txtName"
        txtName.Size = New Size(332, 31)
        txtName.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.ImeMode = ImeMode.NoControl
        txtEmail.Location = New Point(202, 78)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(332, 31)
        txtEmail.TabIndex = 6
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(202, 129)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(332, 31)
        txtPassword.TabIndex = 7
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(202, 178)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "*"c
        txtConfirmPassword.Size = New Size(332, 31)
        txtConfirmPassword.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(26, 234)
        Label5.Name = "Label5"
        Label5.Size = New Size(213, 25)
        Label5.TabIndex = 9
        Label5.Text = "Already have an account?"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Cursor = Cursors.Hand
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.Highlight
        Label6.Location = New Point(236, 234)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 25)
        Label6.TabIndex = 10
        Label6.Text = "Log In."
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(563, 336)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCreate)
        Name = "Register"
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
