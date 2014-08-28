<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Verification_By_Email
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.verifyButton = New System.Windows.Forms.Button
        Me.verifyCodeTextBox = New System.Windows.Forms.TextBox
        Me.sendAgainLinkLabel = New System.Windows.Forms.LinkLabel
        Me.verifyByEmailFormToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(14, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A verification code has been sent to the admin  Email. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please check the email a" & _
            "nd verify the code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Please Verify the  Code"
        '
        'verifyButton
        '
        Me.verifyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verifyButton.Location = New System.Drawing.Point(238, 171)
        Me.verifyButton.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.verifyButton.Name = "verifyButton"
        Me.verifyButton.Size = New System.Drawing.Size(168, 42)
        Me.verifyButton.TabIndex = 10
        Me.verifyButton.Text = "Verify"
        Me.verifyButton.UseVisualStyleBackColor = True
        '
        'verifyCodeTextBox
        '
        Me.verifyCodeTextBox.Location = New System.Drawing.Point(56, 181)
        Me.verifyCodeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.verifyCodeTextBox.Name = "verifyCodeTextBox"
        Me.verifyCodeTextBox.Size = New System.Drawing.Size(148, 22)
        Me.verifyCodeTextBox.TabIndex = 11
        Me.verifyByEmailFormToolTip.SetToolTip(Me.verifyCodeTextBox, "If you close the form the current code will expire")
        '
        'sendAgainLinkLabel
        '
        Me.sendAgainLinkLabel.AutoSize = True
        Me.sendAgainLinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.sendAgainLinkLabel.Location = New System.Drawing.Point(24, 273)
        Me.sendAgainLinkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sendAgainLinkLabel.Name = "sendAgainLinkLabel"
        Me.sendAgainLinkLabel.Size = New System.Drawing.Size(151, 16)
        Me.sendAgainLinkLabel.TabIndex = 12
        Me.sendAgainLinkLabel.TabStop = True
        Me.sendAgainLinkLabel.Text = "Send the code again"
        Me.verifyByEmailFormToolTip.SetToolTip(Me.sendAgainLinkLabel, "Click to send the verification code again")
        '
        'Verification_By_Email
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.ClientSize = New System.Drawing.Size(426, 322)
        Me.Controls.Add(Me.sendAgainLinkLabel)
        Me.Controls.Add(Me.verifyCodeTextBox)
        Me.Controls.Add(Me.verifyButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(434, 359)
        Me.Name = "Verification_By_Email"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verification_By_Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents verifyButton As System.Windows.Forms.Button
    Friend WithEvents verifyCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents sendAgainLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents verifyByEmailFormToolTip As System.Windows.Forms.ToolTip
End Class
