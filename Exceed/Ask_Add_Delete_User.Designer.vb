<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ask_Add_Delete_User
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
        Me.deleteUserComboBox = New System.Windows.Forms.ComboBox
        Me.deleteButton = New System.Windows.Forms.Button
        Me.addUserButton = New System.Windows.Forms.Button
        Me.deleteUserButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'deleteUserComboBox
        '
        Me.deleteUserComboBox.FormattingEnabled = True
        Me.deleteUserComboBox.Location = New System.Drawing.Point(13, 84)
        Me.deleteUserComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.deleteUserComboBox.Name = "deleteUserComboBox"
        Me.deleteUserComboBox.Size = New System.Drawing.Size(338, 24)
        Me.deleteUserComboBox.TabIndex = 9
        Me.deleteUserComboBox.Visible = False
        '
        'deleteButton
        '
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.Location = New System.Drawing.Point(39, 131)
        Me.deleteButton.Margin = New System.Windows.Forms.Padding(4)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(112, 28)
        Me.deleteButton.TabIndex = 10
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        Me.deleteButton.Visible = False
        '
        'addUserButton
        '
        Me.addUserButton.Location = New System.Drawing.Point(39, 38)
        Me.addUserButton.Margin = New System.Windows.Forms.Padding(4)
        Me.addUserButton.Name = "addUserButton"
        Me.addUserButton.Size = New System.Drawing.Size(112, 28)
        Me.addUserButton.TabIndex = 11
        Me.addUserButton.Text = "Add User"
        Me.addUserButton.UseVisualStyleBackColor = True
        '
        'deleteUserButton
        '
        Me.deleteUserButton.Location = New System.Drawing.Point(181, 38)
        Me.deleteUserButton.Margin = New System.Windows.Forms.Padding(4)
        Me.deleteUserButton.Name = "deleteUserButton"
        Me.deleteUserButton.Size = New System.Drawing.Size(112, 28)
        Me.deleteUserButton.TabIndex = 12
        Me.deleteUserButton.Text = "Delete User"
        Me.deleteUserButton.UseVisualStyleBackColor = True
        '
        'Ask_Add_Delete_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.ClientSize = New System.Drawing.Size(388, 186)
        Me.Controls.Add(Me.deleteUserButton)
        Me.Controls.Add(Me.addUserButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.deleteUserComboBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(396, 223)
        Me.Name = "Ask_Add_Delete_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ask_Add_Delete_User"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents deleteUserComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents addUserButton As System.Windows.Forms.Button
    Friend WithEvents deleteUserButton As System.Windows.Forms.Button
End Class
