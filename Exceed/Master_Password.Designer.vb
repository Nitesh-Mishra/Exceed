<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Master_Password
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
        Me.masterPasswordTextBox = New System.Windows.Forms.TextBox
        Me.masterPasswordLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'resetNewPasswordButton
        '
        Me.resetNewPasswordButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetNewPasswordButton.Location = New System.Drawing.Point(36, 127)
        Me.resetNewPasswordButton.Margin = New System.Windows.Forms.Padding(4)
        Me.resetNewPasswordButton.Name = "resetNewPasswordButton"
        Me.resetNewPasswordButton.Size = New System.Drawing.Size(94, 31)
        Me.resetNewPasswordButton.TabIndex = 17
        Me.resetNewPasswordButton.Text = "Enter "
        Me.resetNewPasswordButton.UseVisualStyleBackColor = True
        '
        'masterPasswordTextBox
        '
        Me.masterPasswordTextBox.Location = New System.Drawing.Point(33, 76)
        Me.masterPasswordTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.masterPasswordTextBox.Name = "masterPasswordTextBox"
        Me.masterPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.masterPasswordTextBox.Size = New System.Drawing.Size(313, 22)
        Me.masterPasswordTextBox.TabIndex = 1
        '
        'masterPasswordLabel
        '
        Me.masterPasswordLabel.AutoSize = True
        Me.masterPasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.masterPasswordLabel.Location = New System.Drawing.Point(33, 38)
        Me.masterPasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.masterPasswordLabel.Name = "masterPasswordLabel"
        Me.masterPasswordLabel.Size = New System.Drawing.Size(191, 16)
        Me.masterPasswordLabel.TabIndex = 3
        Me.masterPasswordLabel.Text = "Enter the master password"
        '
        'Master_Password
        '
        Me.AcceptButton = Me.resetNewPasswordButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.ClientSize = New System.Drawing.Size(384, 182)
        Me.Controls.Add(Me.masterPasswordLabel)
        Me.Controls.Add(Me.masterPasswordTextBox)
        Me.Controls.Add(Me.resetNewPasswordButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(392, 219)
        Me.Name = "Master_Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents resetNewPasswordButton As System.Windows.Forms.Button
    Friend WithEvents masterPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents masterPasswordLabel As System.Windows.Forms.Label
End Class
