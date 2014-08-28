<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Me.logintxt = New System.Windows.Forms.TextBox
        Me.password = New System.Windows.Forms.TextBox
        Me.Login = New System.Windows.Forms.Button
        Me.masterLinkLabel = New System.Windows.Forms.LinkLabel
        Me.forgotPasswordLinkLabel = New System.Windows.Forms.LinkLabel
        Me.cancel = New System.Windows.Forms.Button
        Me.adminRadioButton = New System.Windows.Forms.RadioButton
        Me.operatorRadioButton = New System.Windows.Forms.RadioButton
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logintxt
        '
        Me.logintxt.AcceptsTab = True
        Me.logintxt.BackColor = System.Drawing.Color.Honeydew
        Me.logintxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logintxt.Location = New System.Drawing.Point(218, 75)
        Me.logintxt.Name = "logintxt"
        Me.logintxt.Size = New System.Drawing.Size(163, 26)
        Me.logintxt.TabIndex = 1
        Me.logintxt.Text = "USERNAME"
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(218, 131)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(163, 26)
        Me.password.TabIndex = 2
        Me.password.Text = "PASSWORD"
        '
        'Login
        '
        Me.Login.AccessibleDescription = ""
        Me.Login.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Login.Location = New System.Drawing.Point(218, 210)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(75, 25)
        Me.Login.TabIndex = 4
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = False
        '
        'masterLinkLabel
        '
        Me.masterLinkLabel.AutoSize = True
        Me.masterLinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.masterLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.masterLinkLabel.Location = New System.Drawing.Point(12, 269)
        Me.masterLinkLabel.Name = "masterLinkLabel"
        Me.masterLinkLabel.Size = New System.Drawing.Size(45, 13)
        Me.masterLinkLabel.TabIndex = 6
        Me.masterLinkLabel.TabStop = True
        Me.masterLinkLabel.Text = "Master"
        '
        'forgotPasswordLinkLabel
        '
        Me.forgotPasswordLinkLabel.AutoSize = True
        Me.forgotPasswordLinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.forgotPasswordLinkLabel.DisabledLinkColor = System.Drawing.Color.Black
        Me.forgotPasswordLinkLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.forgotPasswordLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.forgotPasswordLinkLabel.Location = New System.Drawing.Point(369, 269)
        Me.forgotPasswordLinkLabel.Name = "forgotPasswordLinkLabel"
        Me.forgotPasswordLinkLabel.Size = New System.Drawing.Size(111, 13)
        Me.forgotPasswordLinkLabel.TabIndex = 7
        Me.forgotPasswordLinkLabel.TabStop = True
        Me.forgotPasswordLinkLabel.Text = "Forgot password ?"
        '
        'cancel
        '
        Me.cancel.BackColor = System.Drawing.Color.White
        Me.cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cancel.Location = New System.Drawing.Point(306, 210)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 25)
        Me.cancel.TabIndex = 5
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = False
        '
        'adminRadioButton
        '
        Me.adminRadioButton.AutoSize = True
        Me.adminRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.adminRadioButton.Location = New System.Drawing.Point(235, 170)
        Me.adminRadioButton.Name = "adminRadioButton"
        Me.adminRadioButton.Size = New System.Drawing.Size(59, 17)
        Me.adminRadioButton.TabIndex = 3
        Me.adminRadioButton.TabStop = True
        Me.adminRadioButton.Text = "Admin"
        Me.adminRadioButton.UseVisualStyleBackColor = False
        '
        'operatorRadioButton
        '
        Me.operatorRadioButton.AutoSize = True
        Me.operatorRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.operatorRadioButton.Location = New System.Drawing.Point(320, 170)
        Me.operatorRadioButton.Name = "operatorRadioButton"
        Me.operatorRadioButton.Size = New System.Drawing.Size(74, 17)
        Me.operatorRadioButton.TabIndex = 52
        Me.operatorRadioButton.TabStop = True
        Me.operatorRadioButton.Text = "Operator"
        Me.operatorRadioButton.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(146, 121)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 50
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(146, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(25, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(440, 31)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "EXCEED COACHING INSTITUTE"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(2, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 10)
        Me.Panel1.TabIndex = 54
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(3, 249)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(495, 10)
        Me.Panel2.TabIndex = 55
        '
        'loginForm
        '
        Me.AcceptButton = Me.Login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.ClientSize = New System.Drawing.Size(501, 291)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.masterLinkLabel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.forgotPasswordLinkLabel)
        Me.Controls.Add(Me.operatorRadioButton)
        Me.Controls.Add(Me.adminRadioButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.logintxt)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(509, 328)
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logintxt As System.Windows.Forms.TextBox
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents Login As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents forgotPasswordLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents masterLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents adminRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents operatorRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
