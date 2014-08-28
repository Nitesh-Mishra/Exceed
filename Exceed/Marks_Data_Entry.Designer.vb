<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Marks_Data_Entry
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
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Start_Entry = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.maxmarks = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Finish = New System.Windows.Forms.Button
        Me.sname = New System.Windows.Forms.Label
        Me.Marks_Obt = New System.Windows.Forms.TextBox
        Me.absent = New System.Windows.Forms.RadioButton
        Me.present = New System.Windows.Forms.RadioButton
        Me.Stud_Id = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.save = New System.Windows.Forms.Button
        Me.TestId = New System.Windows.Forms.ComboBox
        Me.Class_Name = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DOT = New System.Windows.Forms.DateTimePicker
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.BS = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Start_Entry)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TestId)
        Me.GroupBox1.Controls.Add(Me.Class_Name)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DOT)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(445, 485)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Start_Entry
        '
        Me.Start_Entry.Location = New System.Drawing.Point(244, 190)
        Me.Start_Entry.Margin = New System.Windows.Forms.Padding(4)
        Me.Start_Entry.Name = "Start_Entry"
        Me.Start_Entry.Size = New System.Drawing.Size(95, 25)
        Me.Start_Entry.TabIndex = 4
        Me.Start_Entry.Text = "Start Entry"
        Me.Start_Entry.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.maxmarks)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Finish)
        Me.GroupBox2.Controls.Add(Me.sname)
        Me.GroupBox2.Controls.Add(Me.Marks_Obt)
        Me.GroupBox2.Controls.Add(Me.absent)
        Me.GroupBox2.Controls.Add(Me.present)
        Me.GroupBox2.Controls.Add(Me.Stud_Id)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.save)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 222)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(431, 256)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'maxmarks
        '
        Me.maxmarks.Location = New System.Drawing.Point(294, 146)
        Me.maxmarks.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.maxmarks.Name = "maxmarks"
        Me.maxmarks.Size = New System.Drawing.Size(98, 22)
        Me.maxmarks.TabIndex = 45
        Me.maxmarks.Text = "Max Marks"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(276, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 36)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "/"
        '
        'Finish
        '
        Me.Finish.Location = New System.Drawing.Point(188, 193)
        Me.Finish.Margin = New System.Windows.Forms.Padding(4)
        Me.Finish.Name = "Finish"
        Me.Finish.Size = New System.Drawing.Size(95, 25)
        Me.Finish.TabIndex = 10
        Me.Finish.Text = "Finish Entry"
        Me.Finish.UseVisualStyleBackColor = True
        '
        'sname
        '
        Me.sname.Location = New System.Drawing.Point(226, 66)
        Me.sname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sname.Name = "sname"
        Me.sname.Size = New System.Drawing.Size(200, 16)
        Me.sname.TabIndex = 42
        Me.sname.Text = "(Student Name)"
        '
        'Marks_Obt
        '
        Me.Marks_Obt.Location = New System.Drawing.Point(188, 143)
        Me.Marks_Obt.Margin = New System.Windows.Forms.Padding(4)
        Me.Marks_Obt.Name = "Marks_Obt"
        Me.Marks_Obt.Size = New System.Drawing.Size(95, 22)
        Me.Marks_Obt.TabIndex = 8
        '
        'absent
        '
        Me.absent.AutoSize = True
        Me.absent.Location = New System.Drawing.Point(294, 101)
        Me.absent.Margin = New System.Windows.Forms.Padding(4)
        Me.absent.Name = "absent"
        Me.absent.Size = New System.Drawing.Size(74, 20)
        Me.absent.TabIndex = 7
        Me.absent.TabStop = True
        Me.absent.Text = "Absent"
        Me.absent.UseVisualStyleBackColor = True
        '
        'present
        '
        Me.present.AutoSize = True
        Me.present.Location = New System.Drawing.Point(194, 101)
        Me.present.Margin = New System.Windows.Forms.Padding(4)
        Me.present.Name = "present"
        Me.present.Size = New System.Drawing.Size(79, 20)
        Me.present.TabIndex = 6
        Me.present.TabStop = True
        Me.present.Text = "Present"
        Me.present.UseVisualStyleBackColor = True
        '
        'Stud_Id
        '
        Me.Stud_Id.FormattingEnabled = True
        Me.Stud_Id.Location = New System.Drawing.Point(194, 38)
        Me.Stud_Id.Margin = New System.Windows.Forms.Padding(4)
        Me.Stud_Id.Name = "Stud_Id"
        Me.Stud_Id.Size = New System.Drawing.Size(180, 24)
        Me.Stud_Id.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 143)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Marks Obtained"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 101)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Test Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Student Id"
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(55, 193)
        Me.save.Margin = New System.Windows.Forms.Padding(4)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(95, 25)
        Me.save.TabIndex = 9
        Me.save.Text = "Next"
        Me.save.UseVisualStyleBackColor = True
        '
        'TestId
        '
        Me.TestId.FormattingEnabled = True
        Me.TestId.Location = New System.Drawing.Point(207, 135)
        Me.TestId.Margin = New System.Windows.Forms.Padding(4)
        Me.TestId.Name = "TestId"
        Me.TestId.Size = New System.Drawing.Size(180, 24)
        Me.TestId.TabIndex = 3
        '
        'Class_Name
        '
        Me.Class_Name.FormattingEnabled = True
        Me.Class_Name.Location = New System.Drawing.Point(207, 86)
        Me.Class_Name.Margin = New System.Windows.Forms.Padding(4)
        Me.Class_Name.Name = "Class_Name"
        Me.Class_Name.Size = New System.Drawing.Size(180, 24)
        Me.Class_Name.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 143)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Test Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Class"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Date of Test"
        '
        'DOT
        '
        Me.DOT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOT.Location = New System.Drawing.Point(207, 36)
        Me.DOT.Margin = New System.Windows.Forms.Padding(4)
        Me.DOT.Name = "DOT"
        Me.DOT.Size = New System.Drawing.Size(180, 22)
        Me.DOT.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(474, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(299, 226)
        Me.DataGridView1.TabIndex = 28
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(474, 250)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(299, 248)
        Me.DataGridView2.TabIndex = 29
        '
        'Marks_Data_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.ClientSize = New System.Drawing.Size(784, 507)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 545)
        Me.Name = "Marks_Data_Entry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marks Data Entry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TestId As System.Windows.Forms.ComboBox
    Friend WithEvents Class_Name As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DOT As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Marks_Obt As System.Windows.Forms.TextBox
    Friend WithEvents absent As System.Windows.Forms.RadioButton
    Friend WithEvents present As System.Windows.Forms.RadioButton
    Friend WithEvents Stud_Id As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents Start_Entry As System.Windows.Forms.Button
    Friend WithEvents sname As System.Windows.Forms.Label
    Friend WithEvents Finish As System.Windows.Forms.Button
    Friend WithEvents BS As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents maxmarks As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
End Class
