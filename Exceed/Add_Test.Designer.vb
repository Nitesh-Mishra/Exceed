<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Test
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dot = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.testid = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Back = New System.Windows.Forms.Button
        Me.Save = New System.Windows.Forms.Button
        Me.mmarks = New System.Windows.Forms.TextBox
        Me.subidcombo = New System.Windows.Forms.ComboBox
        Me.cnamecombo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dot)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.testid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Back)
        Me.GroupBox1.Controls.Add(Me.Save)
        Me.GroupBox1.Controls.Add(Me.mmarks)
        Me.GroupBox1.Controls.Add(Me.subidcombo)
        Me.GroupBox1.Controls.Add(Me.cnamecombo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 298)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Test"
        '
        'dot
        '
        Me.dot.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dot.Location = New System.Drawing.Point(138, 38)
        Me.dot.Name = "dot"
        Me.dot.Size = New System.Drawing.Size(131, 22)
        Me.dot.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Date of Test"
        '
        'testid
        '
        Me.testid.Location = New System.Drawing.Point(138, 153)
        Me.testid.Name = "testid"
        Me.testid.Size = New System.Drawing.Size(130, 22)
        Me.testid.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Test Id"
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(163, 233)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(104, 29)
        Me.Back.TabIndex = 6
        Me.Back.Text = "Main Menu"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(15, 233)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(104, 29)
        Me.Save.TabIndex = 5
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'mmarks
        '
        Me.mmarks.Location = New System.Drawing.Point(137, 190)
        Me.mmarks.Name = "mmarks"
        Me.mmarks.Size = New System.Drawing.Size(130, 22)
        Me.mmarks.TabIndex = 4
        '
        'subidcombo
        '
        Me.subidcombo.FormattingEnabled = True
        Me.subidcombo.Location = New System.Drawing.Point(138, 114)
        Me.subidcombo.Name = "subidcombo"
        Me.subidcombo.Size = New System.Drawing.Size(130, 24)
        Me.subidcombo.TabIndex = 2
        '
        'cnamecombo
        '
        Me.cnamecombo.FormattingEnabled = True
        Me.cnamecombo.Location = New System.Drawing.Point(139, 75)
        Me.cnamecombo.Name = "cnamecombo"
        Me.cnamecombo.Size = New System.Drawing.Size(130, 24)
        Me.cnamecombo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Max Marks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Subject Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Class"
        '
        'Add_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.ClientSize = New System.Drawing.Size(329, 328)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(337, 365)
        Me.MinimumSize = New System.Drawing.Size(337, 365)
        Me.Name = "Add_Test"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Test"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents mmarks As System.Windows.Forms.TextBox
    Friend WithEvents subidcombo As System.Windows.Forms.ComboBox
    Friend WithEvents cnamecombo As System.Windows.Forms.ComboBox
    Friend WithEvents testid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dot As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
