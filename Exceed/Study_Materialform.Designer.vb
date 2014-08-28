<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Study_Materialform
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.resetbutton = New System.Windows.Forms.Button
        Me.sm_savebutton = New System.Windows.Forms.Button
        Me.sm_notreadyradio = New System.Windows.Forms.RadioButton
        Me.sm_readyradio = New System.Windows.Forms.RadioButton
        Me.sm_topictextbox = New System.Windows.Forms.TextBox
        Me.sm_subcombo = New System.Windows.Forms.ComboBox
        Me.sm_classcombo = New System.Windows.Forms.ComboBox
        Me.sm_yearcombo = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.reportbutton = New System.Windows.Forms.Button
        Me.subjectidcombobox = New System.Windows.Forms.ComboBox
        Me.classcombobox = New System.Windows.Forms.ComboBox
        Me.yearcombobox = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(391, 20)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(547, 480)
        Me.DataGridView1.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.resetbutton)
        Me.GroupBox1.Controls.Add(Me.sm_savebutton)
        Me.GroupBox1.Controls.Add(Me.sm_notreadyradio)
        Me.GroupBox1.Controls.Add(Me.sm_readyradio)
        Me.GroupBox1.Controls.Add(Me.sm_topictextbox)
        Me.GroupBox1.Controls.Add(Me.sm_subcombo)
        Me.GroupBox1.Controls.Add(Me.sm_classcombo)
        Me.GroupBox1.Controls.Add(Me.sm_yearcombo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 285)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Study Material Entry"
        '
        'resetbutton
        '
        Me.resetbutton.Location = New System.Drawing.Point(203, 238)
        Me.resetbutton.Margin = New System.Windows.Forms.Padding(4)
        Me.resetbutton.Name = "resetbutton"
        Me.resetbutton.Size = New System.Drawing.Size(112, 28)
        Me.resetbutton.TabIndex = 25
        Me.resetbutton.Text = "Reset"
        Me.resetbutton.UseVisualStyleBackColor = True
        '
        'sm_savebutton
        '
        Me.sm_savebutton.Location = New System.Drawing.Point(66, 238)
        Me.sm_savebutton.Margin = New System.Windows.Forms.Padding(4)
        Me.sm_savebutton.Name = "sm_savebutton"
        Me.sm_savebutton.Size = New System.Drawing.Size(112, 28)
        Me.sm_savebutton.TabIndex = 24
        Me.sm_savebutton.Text = "Save"
        Me.sm_savebutton.UseVisualStyleBackColor = True
        '
        'sm_notreadyradio
        '
        Me.sm_notreadyradio.AutoSize = True
        Me.sm_notreadyradio.Location = New System.Drawing.Point(246, 187)
        Me.sm_notreadyradio.Margin = New System.Windows.Forms.Padding(4)
        Me.sm_notreadyradio.Name = "sm_notreadyradio"
        Me.sm_notreadyradio.Size = New System.Drawing.Size(100, 20)
        Me.sm_notreadyradio.TabIndex = 23
        Me.sm_notreadyradio.TabStop = True
        Me.sm_notreadyradio.Text = "Not Ready"
        Me.sm_notreadyradio.UseVisualStyleBackColor = True
        '
        'sm_readyradio
        '
        Me.sm_readyradio.AutoSize = True
        Me.sm_readyradio.Location = New System.Drawing.Point(148, 187)
        Me.sm_readyradio.Margin = New System.Windows.Forms.Padding(4)
        Me.sm_readyradio.Name = "sm_readyradio"
        Me.sm_readyradio.Size = New System.Drawing.Size(72, 20)
        Me.sm_readyradio.TabIndex = 22
        Me.sm_readyradio.TabStop = True
        Me.sm_readyradio.Text = "Ready"
        Me.sm_readyradio.UseVisualStyleBackColor = True
        '
        'sm_topictextbox
        '
        Me.sm_topictextbox.Location = New System.Drawing.Point(148, 146)
        Me.sm_topictextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.sm_topictextbox.Name = "sm_topictextbox"
        Me.sm_topictextbox.Size = New System.Drawing.Size(180, 22)
        Me.sm_topictextbox.TabIndex = 21
        '
        'sm_subcombo
        '
        Me.sm_subcombo.FormattingEnabled = True
        Me.sm_subcombo.Location = New System.Drawing.Point(148, 106)
        Me.sm_subcombo.Margin = New System.Windows.Forms.Padding(4)
        Me.sm_subcombo.Name = "sm_subcombo"
        Me.sm_subcombo.Size = New System.Drawing.Size(180, 24)
        Me.sm_subcombo.TabIndex = 20
        '
        'sm_classcombo
        '
        Me.sm_classcombo.FormattingEnabled = True
        Me.sm_classcombo.Location = New System.Drawing.Point(148, 71)
        Me.sm_classcombo.Margin = New System.Windows.Forms.Padding(4)
        Me.sm_classcombo.Name = "sm_classcombo"
        Me.sm_classcombo.Size = New System.Drawing.Size(180, 24)
        Me.sm_classcombo.TabIndex = 19
        '
        'sm_yearcombo
        '
        Me.sm_yearcombo.FormattingEnabled = True
        Me.sm_yearcombo.Location = New System.Drawing.Point(148, 34)
        Me.sm_yearcombo.Margin = New System.Windows.Forms.Padding(4)
        Me.sm_yearcombo.Name = "sm_yearcombo"
        Me.sm_yearcombo.Size = New System.Drawing.Size(180, 24)
        Me.sm_yearcombo.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 187)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Print Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 146)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Topic"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Subject ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Class"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.reportbutton)
        Me.GroupBox2.Controls.Add(Me.subjectidcombobox)
        Me.GroupBox2.Controls.Add(Me.classcombobox)
        Me.GroupBox2.Controls.Add(Me.yearcombobox)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 312)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(359, 192)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Study Material Report"
        '
        'reportbutton
        '
        Me.reportbutton.Location = New System.Drawing.Point(87, 153)
        Me.reportbutton.Margin = New System.Windows.Forms.Padding(4)
        Me.reportbutton.Name = "reportbutton"
        Me.reportbutton.Size = New System.Drawing.Size(143, 28)
        Me.reportbutton.TabIndex = 27
        Me.reportbutton.Text = "View Report"
        Me.reportbutton.UseVisualStyleBackColor = True
        '
        'subjectidcombobox
        '
        Me.subjectidcombobox.FormattingEnabled = True
        Me.subjectidcombobox.Location = New System.Drawing.Point(157, 107)
        Me.subjectidcombobox.Margin = New System.Windows.Forms.Padding(4)
        Me.subjectidcombobox.Name = "subjectidcombobox"
        Me.subjectidcombobox.Size = New System.Drawing.Size(180, 24)
        Me.subjectidcombobox.TabIndex = 26
        '
        'classcombobox
        '
        Me.classcombobox.FormattingEnabled = True
        Me.classcombobox.Location = New System.Drawing.Point(157, 72)
        Me.classcombobox.Margin = New System.Windows.Forms.Padding(4)
        Me.classcombobox.Name = "classcombobox"
        Me.classcombobox.Size = New System.Drawing.Size(180, 24)
        Me.classcombobox.TabIndex = 25
        '
        'yearcombobox
        '
        Me.yearcombobox.FormattingEnabled = True
        Me.yearcombobox.Location = New System.Drawing.Point(157, 35)
        Me.yearcombobox.Margin = New System.Windows.Forms.Padding(4)
        Me.yearcombobox.Name = "yearcombobox"
        Me.yearcombobox.Size = New System.Drawing.Size(180, 24)
        Me.yearcombobox.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 107)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Subject ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 36)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Year"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 72)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Class"
        '
        'Study_Materialform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.ClientSize = New System.Drawing.Size(962, 516)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(970, 553)
        Me.MinimumSize = New System.Drawing.Size(970, 553)
        Me.Name = "Study_Materialform"
        Me.Text = "Study Material"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents resetbutton As System.Windows.Forms.Button
    Friend WithEvents sm_savebutton As System.Windows.Forms.Button
    Friend WithEvents sm_notreadyradio As System.Windows.Forms.RadioButton
    Friend WithEvents sm_readyradio As System.Windows.Forms.RadioButton
    Friend WithEvents sm_topictextbox As System.Windows.Forms.TextBox
    Friend WithEvents sm_subcombo As System.Windows.Forms.ComboBox
    Friend WithEvents sm_classcombo As System.Windows.Forms.ComboBox
    Friend WithEvents sm_yearcombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents reportbutton As System.Windows.Forms.Button
    Friend WithEvents subjectidcombobox As System.Windows.Forms.ComboBox
    Friend WithEvents classcombobox As System.Windows.Forms.ComboBox
    Friend WithEvents yearcombobox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
