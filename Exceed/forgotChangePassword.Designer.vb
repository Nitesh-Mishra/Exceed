<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgotChangePassword
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
        Me.resetNewPasswordButton = New System.Windows.Forms.Button
        Me.cancelButton = New System.Windows.Forms.Button
        Me.newPasswordTextBox = New System.Windows.Forms.TextBox
        Me.retypePasswordTextBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'resetNewPasswordButton
        '
        Me.resetNewPasswordButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetNewPasswordButton.Location = New System.Drawing.Point(88, 147)
        Me.resetNewPasswordButton.Margin = New System.Windows.Forms.Padding(4)
        Me.resetNewPasswordButton.Name = "resetNewPasswordButton"
        Me.resetNewPasswordButton.Size = New System.Drawing.Size(114, 31)
        Me.resetNewPasswordButton.TabIndex = 16
        Me.resetNewPasswordButton.Text = "Reset"
        Me.resetNewPasswordButton.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton.Location = New System.Drawing.Point(242, 147)
        Me.cancelButton.Margin = New System.Windows.Forms.Padding(4)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(114, 31)
        Me.cancelButton.TabIndex = 17
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'newPasswordTextBox
        '
        Me.newPasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newPasswordTextBox.Location = New System.Drawing.Point(191, 48)
        Me.newPasswordTextBox.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.newPasswordTextBox.Name = "newPasswordTextBox"
        Me.newPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newPasswordTextBox.Size = New System.Drawing.Size(239, 22)
        Me.newPasswordTextBox.TabIndex = 19
        '
        'retypePasswordTextBox
        '
        Me.retypePasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retypePasswordTextBox.Location = New System.Drawing.Point(191, 89)
        Me.retypePasswordTextBox.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.retypePasswordTextBox.Name = "retypePasswordTextBox"
        Me.retypePasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.retypePasswordTextBox.Size = New System.Drawing.Size(239, 22)
        Me.retypePasswordTextBox.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Re-type Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "New Password"
        '
        'forgotChangePassword
        '
        Me.AcceptButton = Me.resetNewPasswordButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.ClientSize = New System.Drawing.Size(446, 201)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.retypePasswordTextBox)
        Me.Controls.Add(Me.newPasswordTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.resetNewPasswordButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(454, 238)
        Me.Name = "forgotChangePassword"
        Me.Text = "forgotChangePassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents resetNewPasswordButton As System.Windows.Forms.Button
    Friend WithEvents cancelButton As System.Windows.Forms.Button
    Friend WithEvents newPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents retypePasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
