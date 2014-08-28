<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Class
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
        Me.subcombo = New System.Windows.Forms.ComboBox
        Me.classradio = New System.Windows.Forms.RadioButton
        Me.subradio = New System.Windows.Forms.RadioButton
        Me.reset = New System.Windows.Forms.Button
        Me.Class_Name = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.classlabel = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Fees = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Sub_Id = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Sub_Name = New System.Windows.Forms.TextBox
        Me.Sub_Idcombo = New System.Windows.Forms.ComboBox
        Me.delete = New System.Windows.Forms.Button
        Me.Save = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.subcombo)
        Me.GroupBox2.Controls.Add(Me.classradio)
        Me.GroupBox2.Controls.Add(Me.subradio)
        Me.GroupBox2.Controls.Add(Me.reset)
        Me.GroupBox2.Controls.Add(Me.Class_Name)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.classlabel)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Fees)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Sub_Id)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Sub_Name)
        Me.GroupBox2.Controls.Add(Me.Sub_Idcombo)
        Me.GroupBox2.Controls.Add(Me.delete)
        Me.GroupBox2.Controls.Add(Me.Save)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(403, 357)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add Class / Subject"
        '
        'subcombo
        '
        Me.subcombo.FormattingEnabled = True
        Me.subcombo.Location = New System.Drawing.Point(174, 87)
        Me.subcombo.Name = "subcombo"
        Me.subcombo.Size = New System.Drawing.Size(159, 24)
        Me.subcombo.TabIndex = 3
        '
        'classradio
        '
        Me.classradio.AutoSize = True
        Me.classradio.Location = New System.Drawing.Point(57, 39)
        Me.classradio.Name = "classradio"
        Me.classradio.Size = New System.Drawing.Size(65, 20)
        Me.classradio.TabIndex = 1
        Me.classradio.TabStop = True
        Me.classradio.Text = "Class"
        Me.classradio.UseVisualStyleBackColor = True
        '
        'subradio
        '
        Me.subradio.AutoSize = True
        Me.subradio.Location = New System.Drawing.Point(174, 39)
        Me.subradio.Name = "subradio"
        Me.subradio.Size = New System.Drawing.Size(78, 20)
        Me.subradio.TabIndex = 2
        Me.subradio.TabStop = True
        Me.subradio.Text = "Subject"
        Me.subradio.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.Location = New System.Drawing.Point(300, 272)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(90, 25)
        Me.reset.TabIndex = 11
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'Class_Name
        '
        Me.Class_Name.Location = New System.Drawing.Point(174, 89)
        Me.Class_Name.Name = "Class_Name"
        Me.Class_Name.Size = New System.Drawing.Size(159, 22)
        Me.Class_Name.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 34)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "(Ex- Class 10 Mathematics = M10 )"
        '
        'classlabel
        '
        Me.classlabel.AutoSize = True
        Me.classlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classlabel.Location = New System.Drawing.Point(36, 94)
        Me.classlabel.Name = "classlabel"
        Me.classlabel.Size = New System.Drawing.Size(47, 17)
        Me.classlabel.TabIndex = 0
        Me.classlabel.Text = "&Class"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "&Fees"
        '
        'Fees
        '
        Me.Fees.Location = New System.Drawing.Point(174, 215)
        Me.Fees.Name = "Fees"
        Me.Fees.Size = New System.Drawing.Size(159, 22)
        Me.Fees.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Subject Id"
        '
        'Sub_Id
        '
        Me.Sub_Id.Location = New System.Drawing.Point(174, 169)
        Me.Sub_Id.Name = "Sub_Id"
        Me.Sub_Id.Size = New System.Drawing.Size(159, 22)
        Me.Sub_Id.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Subject Name"
        '
        'Sub_Name
        '
        Me.Sub_Name.Location = New System.Drawing.Point(174, 131)
        Me.Sub_Name.Name = "Sub_Name"
        Me.Sub_Name.Size = New System.Drawing.Size(159, 22)
        Me.Sub_Name.TabIndex = 5
        '
        'Sub_Idcombo
        '
        Me.Sub_Idcombo.FormattingEnabled = True
        Me.Sub_Idcombo.Location = New System.Drawing.Point(112, 273)
        Me.Sub_Idcombo.Name = "Sub_Idcombo"
        Me.Sub_Idcombo.Size = New System.Drawing.Size(86, 24)
        Me.Sub_Idcombo.TabIndex = 9
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(204, 272)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(90, 25)
        Me.delete.TabIndex = 10
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(16, 273)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(90, 25)
        Me.Save.TabIndex = 8
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Add_Class
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.ClientSize = New System.Drawing.Size(445, 380)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(461, 418)
        Me.Name = "Add_Class"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Class "
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents Sub_Idcombo As System.Windows.Forms.ComboBox
    Friend WithEvents Class_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents classlabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Fees As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Sub_Id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Sub_Name As System.Windows.Forms.TextBox
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents classradio As System.Windows.Forms.RadioButton
    Friend WithEvents subradio As System.Windows.Forms.RadioButton
    Friend WithEvents subcombo As System.Windows.Forms.ComboBox
End Class
