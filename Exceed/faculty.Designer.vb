<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class faculty
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
        Me.record = New System.Windows.Forms.GroupBox
        Me.resetbutton = New System.Windows.Forms.Button
        Me.facultynametextbox = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.submitbutton = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.testnoradio = New System.Windows.Forms.RadioButton
        Me.testyesradio = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.resultnoradio = New System.Windows.Forms.RadioButton
        Me.resultyesradio = New System.Windows.Forms.RadioButton
        Me.remarktextbox = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.topictextbox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Yearcombo = New System.Windows.Forms.ComboBox
        Me.Sub_Id = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.class_detail = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.reportbutton = New System.Windows.Forms.Button
        Me.facultynamecombobox = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.yearcombobox = New System.Windows.Forms.ComboBox
        Me.studentidcombobox = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.classcombobox = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.record.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'record
        '
        Me.record.BackColor = System.Drawing.Color.Transparent
        Me.record.Controls.Add(Me.resetbutton)
        Me.record.Controls.Add(Me.facultynametextbox)
        Me.record.Controls.Add(Me.Label9)
        Me.record.Controls.Add(Me.submitbutton)
        Me.record.Controls.Add(Me.DateTimePicker1)
        Me.record.Controls.Add(Me.Panel2)
        Me.record.Controls.Add(Me.Panel1)
        Me.record.Controls.Add(Me.remarktextbox)
        Me.record.Controls.Add(Me.Label8)
        Me.record.Controls.Add(Me.Label7)
        Me.record.Controls.Add(Me.Label6)
        Me.record.Controls.Add(Me.Label5)
        Me.record.Controls.Add(Me.topictextbox)
        Me.record.Controls.Add(Me.Label2)
        Me.record.Controls.Add(Me.Label4)
        Me.record.Controls.Add(Me.Yearcombo)
        Me.record.Controls.Add(Me.Sub_Id)
        Me.record.Controls.Add(Me.Label3)
        Me.record.Controls.Add(Me.class_detail)
        Me.record.Controls.Add(Me.Label1)
        Me.record.Location = New System.Drawing.Point(12, 12)
        Me.record.Name = "record"
        Me.record.Size = New System.Drawing.Size(404, 513)
        Me.record.TabIndex = 27
        Me.record.TabStop = False
        Me.record.Text = "Faculty Information"
        '
        'resetbutton
        '
        Me.resetbutton.Location = New System.Drawing.Point(208, 467)
        Me.resetbutton.Name = "resetbutton"
        Me.resetbutton.Size = New System.Drawing.Size(116, 32)
        Me.resetbutton.TabIndex = 47
        Me.resetbutton.Text = "Reset"
        Me.resetbutton.UseVisualStyleBackColor = True
        '
        'facultynametextbox
        '
        Me.facultynametextbox.Location = New System.Drawing.Point(156, 179)
        Me.facultynametextbox.Multiline = True
        Me.facultynametextbox.Name = "facultynametextbox"
        Me.facultynametextbox.Size = New System.Drawing.Size(199, 20)
        Me.facultynametextbox.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Faculty Name"
        '
        'submitbutton
        '
        Me.submitbutton.Location = New System.Drawing.Point(72, 467)
        Me.submitbutton.Name = "submitbutton"
        Me.submitbutton.Size = New System.Drawing.Size(116, 32)
        Me.submitbutton.TabIndex = 34
        Me.submitbutton.Text = "Submit"
        Me.submitbutton.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(157, 267)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(199, 22)
        Me.DateTimePicker1.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.testnoradio)
        Me.Panel2.Controls.Add(Me.testyesradio)
        Me.Panel2.Location = New System.Drawing.Point(157, 310)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(199, 35)
        Me.Panel2.TabIndex = 44
        '
        'testnoradio
        '
        Me.testnoradio.AutoSize = True
        Me.testnoradio.Location = New System.Drawing.Point(97, 9)
        Me.testnoradio.Name = "testnoradio"
        Me.testnoradio.Size = New System.Drawing.Size(46, 20)
        Me.testnoradio.TabIndex = 7
        Me.testnoradio.TabStop = True
        Me.testnoradio.Text = "No"
        Me.testnoradio.UseVisualStyleBackColor = True
        '
        'testyesradio
        '
        Me.testyesradio.AutoSize = True
        Me.testyesradio.Location = New System.Drawing.Point(16, 9)
        Me.testyesradio.Name = "testyesradio"
        Me.testyesradio.Size = New System.Drawing.Size(53, 20)
        Me.testyesradio.TabIndex = 6
        Me.testyesradio.TabStop = True
        Me.testyesradio.Text = "Yes"
        Me.testyesradio.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.resultnoradio)
        Me.Panel1.Controls.Add(Me.resultyesradio)
        Me.Panel1.Location = New System.Drawing.Point(157, 362)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(199, 35)
        Me.Panel1.TabIndex = 43
        '
        'resultnoradio
        '
        Me.resultnoradio.AutoSize = True
        Me.resultnoradio.Location = New System.Drawing.Point(97, 9)
        Me.resultnoradio.Name = "resultnoradio"
        Me.resultnoradio.Size = New System.Drawing.Size(46, 20)
        Me.resultnoradio.TabIndex = 9
        Me.resultnoradio.TabStop = True
        Me.resultnoradio.Text = "No"
        Me.resultnoradio.UseVisualStyleBackColor = True
        '
        'resultyesradio
        '
        Me.resultyesradio.AutoSize = True
        Me.resultyesradio.Location = New System.Drawing.Point(16, 9)
        Me.resultyesradio.Name = "resultyesradio"
        Me.resultyesradio.Size = New System.Drawing.Size(53, 20)
        Me.resultyesradio.TabIndex = 8
        Me.resultyesradio.TabStop = True
        Me.resultyesradio.Text = "Yes"
        Me.resultyesradio.UseVisualStyleBackColor = True
        '
        'remarktextbox
        '
        Me.remarktextbox.Location = New System.Drawing.Point(157, 413)
        Me.remarktextbox.Multiline = True
        Me.remarktextbox.Name = "remarktextbox"
        Me.remarktextbox.Size = New System.Drawing.Size(199, 20)
        Me.remarktextbox.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 416)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 16)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Remark"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 373)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Result"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Test"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Date"
        '
        'topictextbox
        '
        Me.topictextbox.Location = New System.Drawing.Point(157, 222)
        Me.topictextbox.Multiline = True
        Me.topictextbox.Name = "topictextbox"
        Me.topictextbox.Size = New System.Drawing.Size(199, 20)
        Me.topictextbox.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Topic"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Year"
        '
        'Yearcombo
        '
        Me.Yearcombo.FormattingEnabled = True
        Me.Yearcombo.Location = New System.Drawing.Point(157, 36)
        Me.Yearcombo.Name = "Yearcombo"
        Me.Yearcombo.Size = New System.Drawing.Size(199, 24)
        Me.Yearcombo.TabIndex = 27
        '
        'Sub_Id
        '
        Me.Sub_Id.FormattingEnabled = True
        Me.Sub_Id.Location = New System.Drawing.Point(157, 130)
        Me.Sub_Id.Name = "Sub_Id"
        Me.Sub_Id.Size = New System.Drawing.Size(199, 24)
        Me.Sub_Id.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Subject Id"
        '
        'class_detail
        '
        Me.class_detail.FormattingEnabled = True
        Me.class_detail.Location = New System.Drawing.Point(157, 81)
        Me.class_detail.Name = "class_detail"
        Me.class_detail.Size = New System.Drawing.Size(199, 24)
        Me.class_detail.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Class"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.reportbutton)
        Me.GroupBox1.Controls.Add(Me.facultynamecombobox)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.yearcombobox)
        Me.GroupBox1.Controls.Add(Me.studentidcombobox)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.classcombobox)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(430, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 337)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Faculty Report"
        '
        'reportbutton
        '
        Me.reportbutton.Location = New System.Drawing.Point(88, 266)
        Me.reportbutton.Name = "reportbutton"
        Me.reportbutton.Size = New System.Drawing.Size(141, 32)
        Me.reportbutton.TabIndex = 49
        Me.reportbutton.Text = "View Report"
        Me.reportbutton.UseVisualStyleBackColor = True
        '
        'facultynamecombobox
        '
        Me.facultynamecombobox.FormattingEnabled = True
        Me.facultynamecombobox.Location = New System.Drawing.Point(138, 193)
        Me.facultynamecombobox.Name = "facultynamecombobox"
        Me.facultynamecombobox.Size = New System.Drawing.Size(199, 24)
        Me.facultynamecombobox.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 201)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 16)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Faculty Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 16)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Year"
        '
        'yearcombobox
        '
        Me.yearcombobox.FormattingEnabled = True
        Me.yearcombobox.Location = New System.Drawing.Point(138, 54)
        Me.yearcombobox.Name = "yearcombobox"
        Me.yearcombobox.Size = New System.Drawing.Size(199, 24)
        Me.yearcombobox.TabIndex = 38
        '
        'studentidcombobox
        '
        Me.studentidcombobox.FormattingEnabled = True
        Me.studentidcombobox.Location = New System.Drawing.Point(138, 148)
        Me.studentidcombobox.Name = "studentidcombobox"
        Me.studentidcombobox.Size = New System.Drawing.Size(199, 24)
        Me.studentidcombobox.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 16)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Subject Id"
        '
        'classcombobox
        '
        Me.classcombobox.FormattingEnabled = True
        Me.classcombobox.Location = New System.Drawing.Point(138, 99)
        Me.classcombobox.Name = "classcombobox"
        Me.classcombobox.Size = New System.Drawing.Size(199, 24)
        Me.classcombobox.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 16)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Class"
        '
        'faculty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.ClientSize = New System.Drawing.Size(812, 536)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.record)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(828, 574)
        Me.Name = "faculty"
        Me.Text = "faculty"
        Me.record.ResumeLayout(False)
        Me.record.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents record As System.Windows.Forms.GroupBox
    Friend WithEvents facultynametextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents submitbutton As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents testnoradio As System.Windows.Forms.RadioButton
    Friend WithEvents testyesradio As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents resultnoradio As System.Windows.Forms.RadioButton
    Friend WithEvents resultyesradio As System.Windows.Forms.RadioButton
    Friend WithEvents remarktextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents topictextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Yearcombo As System.Windows.Forms.ComboBox
    Friend WithEvents Sub_Id As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents class_detail As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents facultynamecombobox As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents yearcombobox As System.Windows.Forms.ComboBox
    Friend WithEvents studentidcombobox As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents classcombobox As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents reportbutton As System.Windows.Forms.Button
    Friend WithEvents resetbutton As System.Windows.Forms.Button
End Class
