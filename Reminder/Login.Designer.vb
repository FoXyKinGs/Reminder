<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnLogin = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        Label3 = New Label()
        btnCreateOne = New Label()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Cursor = Cursors.Hand
        btnLogin.Location = New Point(290, 161)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(206, 34)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 25)
        Label1.TabIndex = 1
        Label1.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 25)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(139, 26)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(357, 31)
        txtEmail.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(139, 81)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(357, 31)
        txtPassword.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(197, 25)
        Label3.TabIndex = 5
        Label3.Text = "Don't have an account?"
        ' 
        ' btnCreateOne
        ' 
        btnCreateOne.AutoSize = True
        btnCreateOne.Cursor = Cursors.Hand
        btnCreateOne.Font = New Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        btnCreateOne.ForeColor = SystemColors.Highlight
        btnCreateOne.Location = New Point(216, 120)
        btnCreateOne.Name = "btnCreateOne"
        btnCreateOne.Size = New Size(101, 25)
        btnCreateOne.TabIndex = 6
        btnCreateOne.Text = "Create one."
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(529, 217)
        Controls.Add(btnCreateOne)
        Controls.Add(Label3)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnLogin)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCreateOne As Label

End Class
