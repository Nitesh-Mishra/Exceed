<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
    Inherits System.Windows.Forms.Form

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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.sid_combo = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.to_date = New System.Windows.Forms.DateTimePicker
        Me.from_date = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.viewReportButton = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.yearComboBox = New System.Windows.Forms.ComboBox
        Me.studentidcombobox = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.classcombobox = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.classwisebtn = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.yearcombo = New System.Windows.Forms.ComboBox
        Me.testid_combo = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.classcombo = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.namelabel = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.GroupBox2.Controls.Add(Me.namelabel)
        Me.GroupBox2.Controls.Add(Me.sid_combo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.to_date)
        Me.GroupBox2.Controls.Add(Me.from_date)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.viewReportButton)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.yearComboBox)
        Me.GroupBox2.Controls.Add(Me.studentidcombobox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.classcombobox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(40, 30)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(421, 431)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Individual Report"
        '
        'sid_combo
        '
        Me.sid_combo.FormattingEnabled = True
        Me.sid_combo.Location = New System.Drawing.Point(177, 173)
        Me.sid_combo.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.sid_combo.Name = "sid_combo"
        Me.sid_combo.Size = New System.Drawing.Size(191, 24)
        Me.sid_combo.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(33, 176)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 16)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Subject_Id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 312)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 19)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "To"
        '
        'to_date
        '
        Me.to_date.CustomFormat = "yyyy/MM/dd"
        Me.to_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.to_date.Location = New System.Drawing.Point(176, 309)
        Me.to_date.Margin = New System.Windows.Forms.Padding(4)
        Me.to_date.Name = "to_date"
        Me.to_date.Size = New System.Drawing.Size(191, 22)
        Me.to_date.TabIndex = 6
        '
        'from_date
        '
        Me.from_date.CustomFormat = "yyyy/MM/dd"
        Me.from_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.from_date.Location = New System.Drawing.Point(176, 268)
        Me.from_date.Margin = New System.Windows.Forms.Padding(4)
        Me.from_date.Name = "from_date"
        Me.from_date.Size = New System.Drawing.Size(191, 22)
        Me.from_date.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(35, 271)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 19)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "From"
        '
        'viewReportButton
        '
        Me.viewReportButton.Location = New System.Drawing.Point(176, 362)
        Me.viewReportButton.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.viewReportButton.Name = "viewReportButton"
        Me.viewReportButton.Size = New System.Drawing.Size(124, 34)
        Me.viewReportButton.TabIndex = 7
        Me.viewReportButton.Text = "View Report"
        Me.viewReportButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(33, 219)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Student Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 49)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Year"
        '
        'yearComboBox
        '
        Me.yearComboBox.FormattingEnabled = True
        Me.yearComboBox.Location = New System.Drawing.Point(176, 45)
        Me.yearComboBox.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.yearComboBox.Name = "yearComboBox"
        Me.yearComboBox.Size = New System.Drawing.Size(191, 24)
        Me.yearComboBox.TabIndex = 1
        '
        'studentidcombobox
        '
        Me.studentidcombobox.FormattingEnabled = True
        Me.studentidcombobox.Location = New System.Drawing.Point(177, 129)
        Me.studentidcombobox.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.studentidcombobox.Name = "studentidcombobox"
        Me.studentidcombobox.Size = New System.Drawing.Size(191, 24)
        Me.studentidcombobox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(33, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Student_Id"
        '
        'classcombobox
        '
        Me.classcombobox.DisplayMember = "Class_Id"
        Me.classcombobox.FormattingEnabled = True
        Me.classcombobox.Location = New System.Drawing.Point(176, 86)
        Me.classcombobox.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.classcombobox.Name = "classcombobox"
        Me.classcombobox.Size = New System.Drawing.Size(191, 24)
        Me.classcombobox.TabIndex = 2
        Me.classcombobox.ValueMember = "Class_Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(36, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Class"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.classwisebtn)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.yearcombo)
        Me.GroupBox1.Controls.Add(Me.testid_combo)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.classcombo)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(485, 30)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(331, 235)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Class-Wise Report"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(206, 176)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 34)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Graphical Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'classwisebtn
        '
        Me.classwisebtn.Location = New System.Drawing.Point(57, 176)
        Me.classwisebtn.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.classwisebtn.Name = "classwisebtn"
        Me.classwisebtn.Size = New System.Drawing.Size(115, 34)
        Me.classwisebtn.TabIndex = 11
        Me.classwisebtn.Text = "View Report"
        Me.classwisebtn.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(27, 49)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 16)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Year"
        '
        'yearcombo
        '
        Me.yearcombo.FormattingEnabled = True
        Me.yearcombo.Location = New System.Drawing.Point(117, 46)
        Me.yearcombo.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.yearcombo.Name = "yearcombo"
        Me.yearcombo.Size = New System.Drawing.Size(172, 24)
        Me.yearcombo.TabIndex = 8
        '
        'testid_combo
        '
        Me.testid_combo.FormattingEnabled = True
        Me.testid_combo.Location = New System.Drawing.Point(117, 129)
        Me.testid_combo.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.testid_combo.Name = "testid_combo"
        Me.testid_combo.Size = New System.Drawing.Size(174, 24)
        Me.testid_combo.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(27, 132)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 16)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "test_Id"
        '
        'classcombo
        '
        Me.classcombo.DisplayMember = "Class_Id"
        Me.classcombo.FormattingEnabled = True
        Me.classcombo.Location = New System.Drawing.Point(117, 86)
        Me.classcombo.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.classcombo.Name = "classcombo"
        Me.classcombo.Size = New System.Drawing.Size(174, 24)
        Me.classcombo.TabIndex = 9
        Me.classcombo.ValueMember = "Class_Id"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(27, 89)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 16)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Class"
        '
        'namelabel
        '
        Me.namelabel.AutoSize = True
        Me.namelabel.BackColor = System.Drawing.Color.Transparent
        Me.namelabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namelabel.Location = New System.Drawing.Point(182, 219)
        Me.namelabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.namelabel.Name = "namelabel"
        Me.namelabel.Size = New System.Drawing.Size(0, 19)
        Me.namelabel.TabIndex = 69
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.ClientSize = New System.Drawing.Size(826, 480)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(842, 518)
        Me.Name = "Reports"
        Me.Text = "Reports"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents sid_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents to_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents from_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents viewReportButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents yearComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents studentidcombobox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents classcombobox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents classwisebtn As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents yearcombo As System.Windows.Forms.ComboBox
    Friend WithEvents testid_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents classcombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents namelabel As System.Windows.Forms.Label
End Class
