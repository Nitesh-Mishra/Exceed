<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class emailtest
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
        Me.bodytextbox = New System.Windows.Forms.TextBox
        Me.usernametextbox = New System.Windows.Forms.TextBox
        Me.passwordtextbox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.sendbutton = New System.Windows.Forms.Button
        Me.Body = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.subjecttextbox = New System.Windows.Forms.TextBox
        Me.totextbox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.attachmenttextbox = New System.Windows.Forms.TextBox
        Me.browsebutton = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Label6 = New System.Windows.Forms.Label
        Me.Yearcombo = New System.Windows.Forms.ComboBox
        Me.class_detail = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.emaildatagrid = New System.Windows.Forms.DataGridView
        CType(Me.emaildatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bodytextbox
        '
        Me.bodytextbox.Location = New System.Drawing.Point(99, 396)
        Me.bodytextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.bodytextbox.Multiline = True
        Me.bodytextbox.Name = "bodytextbox"
        Me.bodytextbox.Size = New System.Drawing.Size(502, 103)
        Me.bodytextbox.TabIndex = 5
        '
        'usernametextbox
        '
        Me.usernametextbox.Location = New System.Drawing.Point(102, 558)
        Me.usernametextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.usernametextbox.Name = "usernametextbox"
        Me.usernametextbox.Size = New System.Drawing.Size(371, 22)
        Me.usernametextbox.TabIndex = 7
        '
        'passwordtextbox
        '
        Me.passwordtextbox.Location = New System.Drawing.Point(102, 597)
        Me.passwordtextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.passwordtextbox.Name = "passwordtextbox"
        Me.passwordtextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordtextbox.Size = New System.Drawing.Size(371, 22)
        Me.passwordtextbox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(10, 559)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(10, 595)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'sendbutton
        '
        Me.sendbutton.Location = New System.Drawing.Point(128, 642)
        Me.sendbutton.Margin = New System.Windows.Forms.Padding(4)
        Me.sendbutton.Name = "sendbutton"
        Me.sendbutton.Size = New System.Drawing.Size(112, 28)
        Me.sendbutton.TabIndex = 9
        Me.sendbutton.Text = "Send"
        Me.sendbutton.UseVisualStyleBackColor = True
        '
        'Body
        '
        Me.Body.AutoSize = True
        Me.Body.BackColor = System.Drawing.Color.Transparent
        Me.Body.Location = New System.Drawing.Point(13, 435)
        Me.Body.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Body.Name = "Body"
        Me.Body.Size = New System.Drawing.Size(44, 16)
        Me.Body.TabIndex = 6
        Me.Body.Text = "Body"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(9, 353)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Subject"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(13, 254)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "To"
        '
        'subjecttextbox
        '
        Me.subjecttextbox.Location = New System.Drawing.Point(99, 333)
        Me.subjecttextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.subjecttextbox.Multiline = True
        Me.subjecttextbox.Name = "subjecttextbox"
        Me.subjecttextbox.Size = New System.Drawing.Size(502, 46)
        Me.subjecttextbox.TabIndex = 4
        '
        'totextbox
        '
        Me.totextbox.Location = New System.Drawing.Point(99, 199)
        Me.totextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.totextbox.Multiline = True
        Me.totextbox.Name = "totextbox"
        Me.totextbox.Size = New System.Drawing.Size(502, 117)
        Me.totextbox.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(9, 521)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Attachment"
        '
        'attachmenttextbox
        '
        Me.attachmenttextbox.Location = New System.Drawing.Point(99, 519)
        Me.attachmenttextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.attachmenttextbox.Name = "attachmenttextbox"
        Me.attachmenttextbox.Size = New System.Drawing.Size(374, 22)
        Me.attachmenttextbox.TabIndex = 12
        '
        'browsebutton
        '
        Me.browsebutton.Location = New System.Drawing.Point(481, 517)
        Me.browsebutton.Margin = New System.Windows.Forms.Padding(4)
        Me.browsebutton.Name = "browsebutton"
        Me.browsebutton.Size = New System.Drawing.Size(120, 24)
        Me.browsebutton.TabIndex = 6
        Me.browsebutton.Text = "Browse"
        Me.browsebutton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Select Your File"
        Me.OpenFileDialog1.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*"
        Me.OpenFileDialog1.InitialDirectory = "C:\Users\Nitesh\Desktop"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(15, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Year"
        '
        'Yearcombo
        '
        Me.Yearcombo.FormattingEnabled = True
        Me.Yearcombo.Location = New System.Drawing.Point(103, 39)
        Me.Yearcombo.Name = "Yearcombo"
        Me.Yearcombo.Size = New System.Drawing.Size(137, 24)
        Me.Yearcombo.TabIndex = 1
        '
        'class_detail
        '
        Me.class_detail.FormattingEnabled = True
        Me.class_detail.Location = New System.Drawing.Point(103, 84)
        Me.class_detail.Name = "class_detail"
        Me.class_detail.Size = New System.Drawing.Size(137, 24)
        Me.class_detail.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(15, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Class"
        '
        'emaildatagrid
        '
        Me.emaildatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.emaildatagrid.Location = New System.Drawing.Point(262, 26)
        Me.emaildatagrid.Name = "emaildatagrid"
        Me.emaildatagrid.Size = New System.Drawing.Size(339, 150)
        Me.emaildatagrid.TabIndex = 21
        '
        'emailtest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.ClientSize = New System.Drawing.Size(595, 707)
        Me.Controls.Add(Me.emaildatagrid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Yearcombo)
        Me.Controls.Add(Me.class_detail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.browsebutton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.attachmenttextbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.subjecttextbox)
        Me.Controls.Add(Me.totextbox)
        Me.Controls.Add(Me.Body)
        Me.Controls.Add(Me.sendbutton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.passwordtextbox)
        Me.Controls.Add(Me.usernametextbox)
        Me.Controls.Add(Me.bodytextbox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(611, 745)
        Me.Name = "emailtest"
        Me.Text = "emailtest"
        CType(Me.emaildatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bodytextbox As System.Windows.Forms.TextBox
    Friend WithEvents usernametextbox As System.Windows.Forms.TextBox
    Friend WithEvents passwordtextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents sendbutton As System.Windows.Forms.Button
    Friend WithEvents Body As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents subjecttextbox As System.Windows.Forms.TextBox
    Friend WithEvents totextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents attachmenttextbox As System.Windows.Forms.TextBox
    Friend WithEvents browsebutton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Yearcombo As System.Windows.Forms.ComboBox
    Friend WithEvents class_detail As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents emaildatagrid As System.Windows.Forms.DataGridView
End Class
