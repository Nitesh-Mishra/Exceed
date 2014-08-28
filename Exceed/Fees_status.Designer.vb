<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fees_status
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
        Me.Class_Combo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Studid_Combo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.paid = New System.Windows.Forms.Button
        Me.viewreciept = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.checkddno = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.checkradio = New System.Windows.Forms.RadioButton
        Me.ddradio = New System.Windows.Forms.RadioButton
        Me.cashradio = New System.Windows.Forms.RadioButton
        Me.sessionLabel = New System.Windows.Forms.Label
        Me.totalamounttextbox = New System.Windows.Forms.TextBox
        Me.amounttobepaidtextbox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.amountpaidtextbox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.amountduetextbox = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.dateofpayment = New System.Windows.Forms.DateTimePicker
        Me.discountpanel = New System.Windows.Forms.Panel
        Me.okbutton = New System.Windows.Forms.Button
        Me.Percentlabel = New System.Windows.Forms.Label
        Me.percentbox = New System.Windows.Forms.TextBox
        Me.disamtlabel = New System.Windows.Forms.Label
        Me.percentageradio = New System.Windows.Forms.RadioButton
        Me.Rupeesradio = New System.Windows.Forms.RadioButton
        Me.discountamountbox = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.yesradio = New System.Windows.Forms.RadioButton
        Me.noradio = New System.Windows.Forms.RadioButton
        Me.Panel2.SuspendLayout()
        Me.discountpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Class_Combo
        '
        Me.Class_Combo.FormattingEnabled = True
        Me.Class_Combo.Location = New System.Drawing.Point(168, 89)
        Me.Class_Combo.Margin = New System.Windows.Forms.Padding(4)
        Me.Class_Combo.Name = "Class_Combo"
        Me.Class_Combo.Size = New System.Drawing.Size(197, 24)
        Me.Class_Combo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(26, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Class"
        '
        'Studid_Combo
        '
        Me.Studid_Combo.FormattingEnabled = True
        Me.Studid_Combo.Location = New System.Drawing.Point(168, 132)
        Me.Studid_Combo.Margin = New System.Windows.Forms.Padding(4)
        Me.Studid_Combo.Name = "Studid_Combo"
        Me.Studid_Combo.Size = New System.Drawing.Size(197, 24)
        Me.Studid_Combo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(20, 140)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Student Id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(26, 53)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Session"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(20, 186)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total Amount"
        '
        'paid
        '
        Me.paid.Location = New System.Drawing.Point(42, 599)
        Me.paid.Name = "paid"
        Me.paid.Size = New System.Drawing.Size(112, 31)
        Me.paid.TabIndex = 15
        Me.paid.Text = "Submit"
        Me.paid.UseVisualStyleBackColor = True
        '
        'viewreciept
        '
        Me.viewreciept.Location = New System.Drawing.Point(191, 599)
        Me.viewreciept.Name = "viewreciept"
        Me.viewreciept.Size = New System.Drawing.Size(112, 31)
        Me.viewreciept.TabIndex = 16
        Me.viewreciept.Text = "View Reciept"
        Me.viewreciept.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(20, 332)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Mode of Payment"
        '
        'checkddno
        '
        Me.checkddno.Location = New System.Drawing.Point(168, 375)
        Me.checkddno.Name = "checkddno"
        Me.checkddno.Size = New System.Drawing.Size(197, 22)
        Me.checkddno.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(20, 381)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 16)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Check / DD No."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.checkradio)
        Me.Panel2.Controls.Add(Me.ddradio)
        Me.Panel2.Controls.Add(Me.cashradio)
        Me.Panel2.Location = New System.Drawing.Point(155, 321)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(210, 39)
        Me.Panel2.TabIndex = 9
        '
        'checkradio
        '
        Me.checkradio.AutoSize = True
        Me.checkradio.BackColor = System.Drawing.Color.Transparent
        Me.checkradio.Location = New System.Drawing.Point(79, 8)
        Me.checkradio.Name = "checkradio"
        Me.checkradio.Size = New System.Drawing.Size(69, 20)
        Me.checkradio.TabIndex = 8
        Me.checkradio.TabStop = True
        Me.checkradio.Text = "Check"
        Me.checkradio.UseVisualStyleBackColor = False
        '
        'ddradio
        '
        Me.ddradio.AutoSize = True
        Me.ddradio.BackColor = System.Drawing.Color.Transparent
        Me.ddradio.Location = New System.Drawing.Point(155, 8)
        Me.ddradio.Name = "ddradio"
        Me.ddradio.Size = New System.Drawing.Size(48, 20)
        Me.ddradio.TabIndex = 9
        Me.ddradio.TabStop = True
        Me.ddradio.Text = "DD"
        Me.ddradio.UseVisualStyleBackColor = False
        '
        'cashradio
        '
        Me.cashradio.AutoSize = True
        Me.cashradio.BackColor = System.Drawing.Color.Transparent
        Me.cashradio.Location = New System.Drawing.Point(11, 8)
        Me.cashradio.Name = "cashradio"
        Me.cashradio.Size = New System.Drawing.Size(61, 20)
        Me.cashradio.TabIndex = 7
        Me.cashradio.TabStop = True
        Me.cashradio.Text = "Cash"
        Me.cashradio.UseVisualStyleBackColor = False
        '
        'sessionLabel
        '
        Me.sessionLabel.AutoSize = True
        Me.sessionLabel.BackColor = System.Drawing.Color.Transparent
        Me.sessionLabel.Location = New System.Drawing.Point(165, 53)
        Me.sessionLabel.Name = "sessionLabel"
        Me.sessionLabel.Size = New System.Drawing.Size(0, 16)
        Me.sessionLabel.TabIndex = 33
        '
        'totalamounttextbox
        '
        Me.totalamounttextbox.Location = New System.Drawing.Point(168, 177)
        Me.totalamounttextbox.Name = "totalamounttextbox"
        Me.totalamounttextbox.Size = New System.Drawing.Size(197, 22)
        Me.totalamounttextbox.TabIndex = 4
        '
        'amounttobepaidtextbox
        '
        Me.amounttobepaidtextbox.Location = New System.Drawing.Point(168, 413)
        Me.amounttobepaidtextbox.Name = "amounttobepaidtextbox"
        Me.amounttobepaidtextbox.Size = New System.Drawing.Size(197, 22)
        Me.amounttobepaidtextbox.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(20, 416)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Amount to be Paid"
        '
        'amountpaidtextbox
        '
        Me.amountpaidtextbox.Location = New System.Drawing.Point(168, 458)
        Me.amountpaidtextbox.Name = "amountpaidtextbox"
        Me.amountpaidtextbox.Size = New System.Drawing.Size(197, 22)
        Me.amountpaidtextbox.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(20, 461)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Amount Paid"
        '
        'amountduetextbox
        '
        Me.amountduetextbox.Location = New System.Drawing.Point(168, 500)
        Me.amountduetextbox.Name = "amountduetextbox"
        Me.amountduetextbox.Size = New System.Drawing.Size(197, 22)
        Me.amountduetextbox.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(20, 503)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 16)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Amount Due"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(20, 543)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 16)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Date of Payment"
        '
        'dateofpayment
        '
        Me.dateofpayment.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateofpayment.Location = New System.Drawing.Point(168, 543)
        Me.dateofpayment.Name = "dateofpayment"
        Me.dateofpayment.Size = New System.Drawing.Size(197, 22)
        Me.dateofpayment.TabIndex = 14
        '
        'discountpanel
        '
        Me.discountpanel.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.discountpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.discountpanel.Controls.Add(Me.okbutton)
        Me.discountpanel.Controls.Add(Me.Percentlabel)
        Me.discountpanel.Controls.Add(Me.percentbox)
        Me.discountpanel.Controls.Add(Me.disamtlabel)
        Me.discountpanel.Controls.Add(Me.percentageradio)
        Me.discountpanel.Controls.Add(Me.Rupeesradio)
        Me.discountpanel.Controls.Add(Me.discountamountbox)
        Me.discountpanel.Location = New System.Drawing.Point(273, 209)
        Me.discountpanel.Margin = New System.Windows.Forms.Padding(4)
        Me.discountpanel.Name = "discountpanel"
        Me.discountpanel.Size = New System.Drawing.Size(260, 104)
        Me.discountpanel.TabIndex = 43
        '
        'okbutton
        '
        Me.okbutton.Location = New System.Drawing.Point(131, 67)
        Me.okbutton.Name = "okbutton"
        Me.okbutton.Size = New System.Drawing.Size(45, 22)
        Me.okbutton.TabIndex = 5
        Me.okbutton.Text = "OK"
        Me.okbutton.UseVisualStyleBackColor = True
        '
        'Percentlabel
        '
        Me.Percentlabel.AutoSize = True
        Me.Percentlabel.BackColor = System.Drawing.Color.Transparent
        Me.Percentlabel.Location = New System.Drawing.Point(4, 43)
        Me.Percentlabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Percentlabel.Name = "Percentlabel"
        Me.Percentlabel.Size = New System.Drawing.Size(61, 16)
        Me.Percentlabel.TabIndex = 29
        Me.Percentlabel.Text = "Percent"
        '
        'percentbox
        '
        Me.percentbox.Location = New System.Drawing.Point(75, 40)
        Me.percentbox.Margin = New System.Windows.Forms.Padding(4)
        Me.percentbox.Name = "percentbox"
        Me.percentbox.Size = New System.Drawing.Size(169, 22)
        Me.percentbox.TabIndex = 3
        '
        'disamtlabel
        '
        Me.disamtlabel.AutoSize = True
        Me.disamtlabel.BackColor = System.Drawing.Color.Transparent
        Me.disamtlabel.Location = New System.Drawing.Point(6, 43)
        Me.disamtlabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.disamtlabel.Name = "disamtlabel"
        Me.disamtlabel.Size = New System.Drawing.Size(59, 16)
        Me.disamtlabel.TabIndex = 25
        Me.disamtlabel.Text = "Amount"
        '
        'percentageradio
        '
        Me.percentageradio.AutoSize = True
        Me.percentageradio.BackColor = System.Drawing.Color.Transparent
        Me.percentageradio.Location = New System.Drawing.Point(139, 4)
        Me.percentageradio.Margin = New System.Windows.Forms.Padding(4)
        Me.percentageradio.Name = "percentageradio"
        Me.percentageradio.Size = New System.Drawing.Size(106, 20)
        Me.percentageradio.TabIndex = 2
        Me.percentageradio.TabStop = True
        Me.percentageradio.Text = "Percentage"
        Me.percentageradio.UseVisualStyleBackColor = False
        '
        'Rupeesradio
        '
        Me.Rupeesradio.AutoSize = True
        Me.Rupeesradio.BackColor = System.Drawing.Color.Transparent
        Me.Rupeesradio.Location = New System.Drawing.Point(47, 5)
        Me.Rupeesradio.Margin = New System.Windows.Forms.Padding(4)
        Me.Rupeesradio.Name = "Rupeesradio"
        Me.Rupeesradio.Size = New System.Drawing.Size(80, 20)
        Me.Rupeesradio.TabIndex = 1
        Me.Rupeesradio.TabStop = True
        Me.Rupeesradio.Text = "Rupees"
        Me.Rupeesradio.UseVisualStyleBackColor = False
        '
        'discountamountbox
        '
        Me.discountamountbox.Location = New System.Drawing.Point(75, 39)
        Me.discountamountbox.Margin = New System.Windows.Forms.Padding(4)
        Me.discountamountbox.Name = "discountamountbox"
        Me.discountamountbox.Size = New System.Drawing.Size(169, 22)
        Me.discountamountbox.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(26, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 16)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Discount"
        '
        'yesradio
        '
        Me.yesradio.AutoSize = True
        Me.yesradio.BackColor = System.Drawing.Color.Transparent
        Me.yesradio.Location = New System.Drawing.Point(151, 256)
        Me.yesradio.Name = "yesradio"
        Me.yesradio.Size = New System.Drawing.Size(53, 20)
        Me.yesradio.TabIndex = 5
        Me.yesradio.TabStop = True
        Me.yesradio.Text = "Yes"
        Me.yesradio.UseVisualStyleBackColor = False
        '
        'noradio
        '
        Me.noradio.AutoSize = True
        Me.noradio.BackColor = System.Drawing.Color.Transparent
        Me.noradio.Location = New System.Drawing.Point(210, 256)
        Me.noradio.Name = "noradio"
        Me.noradio.Size = New System.Drawing.Size(46, 20)
        Me.noradio.TabIndex = 6
        Me.noradio.TabStop = True
        Me.noradio.Text = "No"
        Me.noradio.UseVisualStyleBackColor = False
        '
        'Fees_status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.ClientSize = New System.Drawing.Size(554, 656)
        Me.Controls.Add(Me.noradio)
        Me.Controls.Add(Me.yesradio)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.discountpanel)
        Me.Controls.Add(Me.dateofpayment)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.amountduetextbox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.amountpaidtextbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.amounttobepaidtextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.totalamounttextbox)
        Me.Controls.Add(Me.sessionLabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.checkddno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.viewreciept)
        Me.Controls.Add(Me.paid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Studid_Combo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Class_Combo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(570, 694)
        Me.Name = "Fees_status"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fees_status"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.discountpanel.ResumeLayout(False)
        Me.discountpanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Class_Combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Studid_Combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents paid As System.Windows.Forms.Button
    Friend WithEvents viewreciept As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents checkddno As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents checkradio As System.Windows.Forms.RadioButton
    Friend WithEvents ddradio As System.Windows.Forms.RadioButton
    Friend WithEvents cashradio As System.Windows.Forms.RadioButton
    Friend WithEvents sessionLabel As System.Windows.Forms.Label
    Friend WithEvents totalamounttextbox As System.Windows.Forms.TextBox
    Friend WithEvents amounttobepaidtextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents amountpaidtextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents amountduetextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dateofpayment As System.Windows.Forms.DateTimePicker
    Friend WithEvents discountpanel As System.Windows.Forms.Panel
    Friend WithEvents okbutton As System.Windows.Forms.Button
    Friend WithEvents Percentlabel As System.Windows.Forms.Label
    Friend WithEvents percentbox As System.Windows.Forms.TextBox
    Friend WithEvents disamtlabel As System.Windows.Forms.Label
    Friend WithEvents percentageradio As System.Windows.Forms.RadioButton
    Friend WithEvents Rupeesradio As System.Windows.Forms.RadioButton
    Friend WithEvents discountamountbox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents yesradio As System.Windows.Forms.RadioButton
    Friend WithEvents noradio As System.Windows.Forms.RadioButton
End Class
