<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FogortPasswordForm
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
        Me.selectSecurityQuestionComboBox = New System.Windows.Forms.ComboBox
        Me.securityQuestionAnswerTextBox = New System.Windows.Forms.TextBox
        Me.nextButton = New System.Windows.Forms.Button
        Me.selectUserNameComboBox = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'selectSecurityQuestionComboBox
        '
        Me.selectSecurityQuestionComboBox.FormattingEnabled = True
        Me.selectSecurityQuestionComboBox.Location = New System.Drawing.Point(18, 85)
        Me.selectSecurityQuestionComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.selectSecurityQuestionComboBox.Name = "selectSecurityQuestionComboBox"
        Me.selectSecurityQuestionComboBox.Size = New System.Drawing.Size(420, 24)
        Me.selectSecurityQuestionComboBox.TabIndex = 1
        Me.selectSecurityQuestionComboBox.Text = "Select your security question here"
        '
        'securityQuestionAnswerTextBox
        '
        Me.securityQuestionAnswerTextBox.Location = New System.Drawing.Point(20, 139)
        Me.securityQuestionAnswerTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.securityQuestionAnswerTextBox.Name = "securityQuestionAnswerTextBox"
        Me.securityQuestionAnswerTextBox.Size = New System.Drawing.Size(248, 22)
        Me.securityQuestionAnswerTextBox.TabIndex = 2
        Me.securityQuestionAnswerTextBox.Text = "Your Answer"
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(18, 188)
        Me.nextButton.Margin = New System.Windows.Forms.Padding(4)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(112, 28)
        Me.nextButton.TabIndex = 3
        Me.nextButton.Text = "Next >>"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'selectUserNameComboBox
        '
        Me.selectUserNameComboBox.FormattingEnabled = True
        Me.selectUserNameComboBox.Location = New System.Drawing.Point(18, 41)
        Me.selectUserNameComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.selectUserNameComboBox.Name = "selectUserNameComboBox"
        Me.selectUserNameComboBox.Size = New System.Drawing.Size(250, 24)
        Me.selectUserNameComboBox.TabIndex = 0
        Me.selectUserNameComboBox.Text = "Select Your User Name"
        '
        'FogortPasswordForm
        '
        Me.AcceptButton = Me.nextButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.ClientSize = New System.Drawing.Size(448, 235)
        Me.Controls.Add(Me.selectUserNameComboBox)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.securityQuestionAnswerTextBox)
        Me.Controls.Add(Me.selectSecurityQuestionComboBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(464, 273)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(456, 272)
        Me.Name = "FogortPasswordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fogort Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents selectSecurityQuestionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents securityQuestionAnswerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents selectUserNameComboBox As System.Windows.Forms.ComboBox
End Class
