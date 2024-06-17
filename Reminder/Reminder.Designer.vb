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
        lblGreeting = New Label()
        dgUpcomingEvent = New DataGridView()
        dgListEvent = New DataGridView()
        Label4 = New Label()
        Label3 = New Label()
        btnAddEvent = New Button()
        label2 = New Label()
        Label1 = New Label()
        tabSettings = New TabPage()
        Label10 = New Label()
        Label9 = New Label()
        btnChangePassword = New Button()
        btnSaveProfile = New Button()
        txtEmail = New TextBox()
        txtNickname = New TextBox()
        txtName = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        btnLogout = New Button()
        TabControl1.SuspendLayout()
        tabHome.SuspendLayout()
        CType(dgUpcomingEvent, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgListEvent, ComponentModel.ISupportInitialize).BeginInit()
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
        TabControl1.Size = New Size(1013, 731)
        TabControl1.TabIndex = 0
        ' 
        ' tabHome
        ' 
        tabHome.Controls.Add(lblGreeting)
        tabHome.Controls.Add(dgUpcomingEvent)
        tabHome.Controls.Add(dgListEvent)
        tabHome.Controls.Add(Label4)
        tabHome.Controls.Add(Label3)
        tabHome.Controls.Add(btnAddEvent)
        tabHome.Controls.Add(label2)
        tabHome.Controls.Add(Label1)
        tabHome.Location = New Point(4, 34)
        tabHome.Name = "tabHome"
        tabHome.Padding = New Padding(3)
        tabHome.Size = New Size(1005, 693)
        tabHome.TabIndex = 0
        tabHome.Text = "Home"
        tabHome.UseVisualStyleBackColor = True
        ' 
        ' lblGreeting
        ' 
        lblGreeting.AutoSize = True
        lblGreeting.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGreeting.Location = New Point(11, 14)
        lblGreeting.Name = "lblGreeting"
        lblGreeting.Size = New Size(38, 32)
        lblGreeting.TabIndex = 7
        lblGreeting.Text = "..."
        ' 
        ' dgUpcomingEvent
        ' 
        dgUpcomingEvent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgUpcomingEvent.Location = New Point(34, 118)
        dgUpcomingEvent.Name = "dgUpcomingEvent"
        dgUpcomingEvent.RowHeadersWidth = 62
        dgUpcomingEvent.Size = New Size(949, 225)
        dgUpcomingEvent.TabIndex = 6
        ' 
        ' dgListEvent
        ' 
        dgListEvent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgListEvent.Location = New Point(34, 425)
        dgListEvent.Name = "dgListEvent"
        dgListEvent.RowHeadersWidth = 62
        dgListEvent.Size = New Size(949, 225)
        dgListEvent.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(437, 500)
        Label4.Name = "Label4"
        Label4.Size = New Size(157, 25)
        Label4.TabIndex = 4
        Label4.Text = "No event available"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(391, 225)
        Label3.Name = "Label3"
        Label3.Size = New Size(240, 25)
        Label3.TabIndex = 3
        Label3.Text = "There's no up coming events"
        ' 
        ' btnAddEvent
        ' 
        btnAddEvent.Image = CType(resources.GetObject("btnAddEvent.Image"), Image)
        btnAddEvent.ImageAlign = ContentAlignment.MiddleRight
        btnAddEvent.Location = New Point(876, 8)
        btnAddEvent.Name = "btnAddEvent"
        btnAddEvent.Size = New Size(121, 48)
        btnAddEvent.TabIndex = 2
        btnAddEvent.Text = "Add Event"
        btnAddEvent.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAddEvent.UseVisualStyleBackColor = True
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.BackColor = Color.Thistle
        label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label2.Location = New Point(14, 363)
        label2.Name = "label2"
        label2.Size = New Size(90, 38)
        label2.TabIndex = 1
        label2.Text = "Event"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Thistle
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(14, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(245, 38)
        Label1.TabIndex = 0
        Label1.Text = "Up Coming Event"
        ' 
        ' tabSettings
        ' 
        tabSettings.Controls.Add(Label10)
        tabSettings.Controls.Add(Label9)
        tabSettings.Controls.Add(btnChangePassword)
        tabSettings.Controls.Add(btnSaveProfile)
        tabSettings.Controls.Add(txtEmail)
        tabSettings.Controls.Add(txtNickname)
        tabSettings.Controls.Add(txtName)
        tabSettings.Controls.Add(Label8)
        tabSettings.Controls.Add(Label7)
        tabSettings.Controls.Add(Label6)
        tabSettings.Controls.Add(Label5)
        tabSettings.Controls.Add(btnLogout)
        tabSettings.Location = New Point(4, 34)
        tabSettings.Name = "tabSettings"
        tabSettings.Padding = New Padding(3)
        tabSettings.Size = New Size(1005, 693)
        tabSettings.TabIndex = 1
        tabSettings.Text = "Settings"
        tabSettings.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 7F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(450, 251)
        Label10.Name = "Label10"
        Label10.Size = New Size(524, 19)
        Label10.TabIndex = 11
        Label10.Text = "* If the nickname field is empty, the name will be displayed at the front of the app."
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.LightGray
        Label9.Font = New Font("Segoe UI", 28F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(-4, 0)
        Label9.Name = "Label9"
        Label9.RightToLeft = RightToLeft.No
        Label9.Size = New Size(434, 693)
        Label9.TabIndex = 10
        Label9.Text = """Reminders are the whispers of our ambitions, nudging us gently towards the paths we've set for ourselves."""
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.Location = New Point(633, 284)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New Size(169, 34)
        btnChangePassword.TabIndex = 9
        btnChangePassword.Text = "Change Password"
        btnChangePassword.UseVisualStyleBackColor = True
        ' 
        ' btnSaveProfile
        ' 
        btnSaveProfile.BackColor = Color.Transparent
        btnSaveProfile.BackgroundImageLayout = ImageLayout.None
        btnSaveProfile.Cursor = Cursors.Hand
        btnSaveProfile.Location = New Point(449, 284)
        btnSaveProfile.Name = "btnSaveProfile"
        btnSaveProfile.Size = New Size(169, 34)
        btnSaveProfile.TabIndex = 8
        btnSaveProfile.Text = "Save Profile"
        btnSaveProfile.UseVisualStyleBackColor = False
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(600, 204)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(381, 31)
        txtEmail.TabIndex = 7
        ' 
        ' txtNickname
        ' 
        txtNickname.Location = New Point(600, 146)
        txtNickname.Name = "txtNickname"
        txtNickname.Size = New Size(381, 31)
        txtNickname.TabIndex = 6
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(600, 89)
        txtName.Name = "txtName"
        txtName.Size = New Size(381, 31)
        txtName.TabIndex = 5
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(450, 205)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 25)
        Label8.TabIndex = 4
        Label8.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(449, 146)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 25)
        Label7.TabIndex = 3
        Label7.Text = "Nickname"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(450, 90)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 25)
        Label6.TabIndex = 2
        Label6.Text = "Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Thistle
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(449, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 38)
        Label5.TabIndex = 1
        Label5.Text = "Profile"
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.IndianRed
        btnLogout.Location = New Point(450, 648)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(169, 34)
        btnLogout.TabIndex = 0
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Reminder
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1014, 729)
        Controls.Add(TabControl1)
        Name = "Reminder"
        Text = "Reminder"
        TabControl1.ResumeLayout(False)
        tabHome.ResumeLayout(False)
        tabHome.PerformLayout()
        CType(dgUpcomingEvent, ComponentModel.ISupportInitialize).EndInit()
        CType(dgListEvent, ComponentModel.ISupportInitialize).EndInit()
        tabSettings.ResumeLayout(False)
        tabSettings.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabHome As TabPage
    Friend WithEvents tabSettings As TabPage
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddEvent As Button
    Friend WithEvents label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgUpcomingEvent As DataGridView
    Friend WithEvents dgListEvent As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNickname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents btnSaveProfile As Button
    Friend WithEvents lblGreeting As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
