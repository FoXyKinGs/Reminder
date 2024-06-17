<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddReminder
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
        dtpDate = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        txtbNote = New TextBox()
        btnAddReminder = New Button()
        Label3 = New Label()
        txtTitle = New TextBox()
        btnBack = New Button()
        dtpTime = New DateTimePicker()
        SuspendLayout()
        ' 
        ' dtpDate
        ' 
        dtpDate.CustomFormat = ""
        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.Location = New Point(102, 163)
        dtpDate.MinDate = New Date(2024, 6, 12, 0, 0, 0, 0)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(307, 31)
        dtpDate.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 163)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 25)
        Label1.TabIndex = 1
        Label1.Text = "Date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 224)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 25)
        Label2.TabIndex = 2
        Label2.Text = "Note"
        ' 
        ' txtbNote
        ' 
        txtbNote.Location = New Point(102, 224)
        txtbNote.Multiline = True
        txtbNote.Name = "txtbNote"
        txtbNote.ScrollBars = ScrollBars.Horizontal
        txtbNote.Size = New Size(496, 283)
        txtbNote.TabIndex = 3
        ' 
        ' btnAddReminder
        ' 
        btnAddReminder.Location = New Point(203, 522)
        btnAddReminder.Name = "btnAddReminder"
        btnAddReminder.Size = New Size(224, 34)
        btnAddReminder.TabIndex = 4
        btnAddReminder.Text = "Add Reminder"
        btnAddReminder.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 25)
        Label3.TabIndex = 5
        Label3.Text = "Title"
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(102, 106)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(496, 31)
        txtTitle.TabIndex = 6
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(23, 31)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(112, 34)
        btnBack.TabIndex = 7
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' dtpTime
        ' 
        dtpTime.CustomFormat = ""
        dtpTime.Format = DateTimePickerFormat.Time
        dtpTime.Location = New Point(415, 163)
        dtpTime.MinDate = New Date(2024, 6, 12, 0, 0, 0, 0)
        dtpTime.Name = "dtpTime"
        dtpTime.ShowUpDown = True
        dtpTime.Size = New Size(183, 31)
        dtpTime.TabIndex = 8
        ' 
        ' AddReminder
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(621, 568)
        Controls.Add(dtpTime)
        Controls.Add(btnBack)
        Controls.Add(txtTitle)
        Controls.Add(Label3)
        Controls.Add(btnAddReminder)
        Controls.Add(txtbNote)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dtpDate)
        Name = "AddReminder"
        Text = "Add Reminder"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbNote As TextBox
    Friend WithEvents btnAddReminder As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents dtpTime As DateTimePicker
End Class
