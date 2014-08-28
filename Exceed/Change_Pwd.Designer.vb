<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_Pwd
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
        Me.Back = New System.Windows.Forms.Button
        Me.save = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.rpwd = New System.Windows.Forms.TextBox
        Me.npwd = New System.Windows.Forms.TextBox
        Me.opwd = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(210, 203)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(100, 33)
        Me.Back.TabIndex = 5
        Me.Back.Text = "Main Menu"
        Me.Back.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save.Location = New System.Drawing.Point(67, 203)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(96, 33)
        Me.save.TabIndex = 4
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 148)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Re-type Password"
        '
        'rpwd
        '
        Me.rpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rpwd.Location = New System.Drawing.Point(177, 145)
        Me.rpwd.Margin = New System.Windows.Forms.Padding(4)
        Me.rpwd.Name = "rpwd"
        Me.rpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.rpwd.Size = New System.Drawing.Size(217, 22)
        Me.rpwd.TabIndex = 3
        '
        'npwd
        '
        Me.npwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.npwd.Location = New System.Drawing.Point(177, 102)
        Me.npwd.Margin = New System.Windows.Forms.Padding(4)
        Me.npwd.Name = "npwd"
        Me.npwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.npwd.Size = New System.Drawing.Size(217, 22)
        Me.npwd.TabIndex = 2
        '
        'opwd
        '
        Me.opwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opwd.Location = New System.Drawing.Point(177, 54)
        Me.opwd.Margin = New System.Windows.Forms.Padding(4)
        Me.opwd.Name = "opwd"
        Me.opwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.opwd.Size = New System.Drawing.Size(217, 22)
        Me.opwd.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "New Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Old Password"
        '
        'Change_Pwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.ClientSize = New System.Drawing.Size(414, 281)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rpwd)
        Me.Controls.Add(Me.npwd)
        Me.Controls.Add(Me.opwd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(430, 319)
        Me.Name = "Change_Pwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change_Pwd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rpwd As System.Windows.Forms.TextBox
    Friend WithEvents npwd As System.Windows.Forms.TextBox
    Friend WithEvents opwd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
