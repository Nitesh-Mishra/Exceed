<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class assignment
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
        Me.assign = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.mainmenu = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Yearcombo = New System.Windows.Forms.ComboBox
        Me.Sub_Id = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Stud_Id = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.class_detail = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'assign
        '
        Me.assign.Location = New System.Drawing.Point(48, 232)
        Me.assign.Name = "assign"
        Me.assign.Size = New System.Drawing.Size(94, 27)
        Me.assign.TabIndex = 5
        Me.assign.Text = "Assign"
        Me.assign.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.mainmenu)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Yearcombo)
        Me.GroupBox1.Controls.Add(Me.Sub_Id)
        Me.GroupBox1.Controls.Add(Me.assign)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Stud_Id)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.class_detail)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(31, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 277)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assign Subjects"
        '
        'mainmenu
        '
        Me.mainmenu.Location = New System.Drawing.Point(150, 232)
        Me.mainmenu.Name = "mainmenu"
        Me.mainmenu.Size = New System.Drawing.Size(94, 27)
        Me.mainmenu.TabIndex = 6
        Me.mainmenu.Text = "Main Menu"
        Me.mainmenu.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Year"
        '
        'Yearcombo
        '
        Me.Yearcombo.FormattingEnabled = True
        Me.Yearcombo.Location = New System.Drawing.Point(107, 38)
        Me.Yearcombo.Name = "Yearcombo"
        Me.Yearcombo.Size = New System.Drawing.Size(137, 24)
        Me.Yearcombo.TabIndex = 1
        '
        'Sub_Id
        '
        Me.Sub_Id.FormattingEnabled = True
        Me.Sub_Id.Location = New System.Drawing.Point(107, 175)
        Me.Sub_Id.Name = "Sub_Id"
        Me.Sub_Id.Size = New System.Drawing.Size(137, 24)
        Me.Sub_Id.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Subject Id"
        '
        'Stud_Id
        '
        Me.Stud_Id.FormattingEnabled = True
        Me.Stud_Id.Location = New System.Drawing.Point(107, 128)
        Me.Stud_Id.Name = "Stud_Id"
        Me.Stud_Id.Size = New System.Drawing.Size(137, 24)
        Me.Stud_Id.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Student Id"
        '
        'class_detail
        '
        Me.class_detail.FormattingEnabled = True
        Me.class_detail.Location = New System.Drawing.Point(107, 83)
        Me.class_detail.Name = "class_detail"
        Me.class_detail.Size = New System.Drawing.Size(137, 24)
        Me.class_detail.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Class"
        '
        'assignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.ClientSize = New System.Drawing.Size(337, 325)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(353, 363)
        Me.Name = "assignment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assign Subject "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents assign As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents class_detail As System.Windows.Forms.ComboBox
    Friend WithEvents Sub_Id As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Stud_Id As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Yearcombo As System.Windows.Forms.ComboBox
    Friend WithEvents mainmenu As System.Windows.Forms.Button
End Class
