<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fees__Discount
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
        Me.rupeesRadioButton = New System.Windows.Forms.RadioButton
        Me.percentRadioButton = New System.Windows.Forms.RadioButton
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'rupeesRadioButton
        '
        Me.rupeesRadioButton.AutoSize = True
        Me.rupeesRadioButton.Location = New System.Drawing.Point(197, 12)
        Me.rupeesRadioButton.Name = "rupeesRadioButton"
        Me.rupeesRadioButton.Size = New System.Drawing.Size(62, 17)
        Me.rupeesRadioButton.TabIndex = 0
        Me.rupeesRadioButton.TabStop = True
        Me.rupeesRadioButton.Text = "Rupees"
        Me.rupeesRadioButton.UseVisualStyleBackColor = True
        '
        'percentRadioButton
        '
        Me.percentRadioButton.AutoSize = True
        Me.percentRadioButton.Location = New System.Drawing.Point(43, 12)
        Me.percentRadioButton.Name = "percentRadioButton"
        Me.percentRadioButton.Size = New System.Drawing.Size(80, 17)
        Me.percentRadioButton.TabIndex = 1
        Me.percentRadioButton.TabStop = True
        Me.percentRadioButton.Text = "Percentage"
        Me.percentRadioButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(43, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(216, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Fees__Discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 84)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.percentRadioButton)
        Me.Controls.Add(Me.rupeesRadioButton)
        Me.Name = "Fees__Discount"
        Me.Text = "Fees__Discount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rupeesRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents percentRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
