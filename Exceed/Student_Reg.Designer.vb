<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Reg
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cdetail = New System.Windows.Forms.ComboBox
        Me.sid = New System.Windows.Forms.TextBox
        Me.doj = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.pcitextbox = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.slctextbox = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Guardian_Emailbox = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Student_Emailbox = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.sid_groupbox = New System.Windows.Forms.GroupBox
        Me.okbox = New System.Windows.Forms.Button
        Me.idbox = New System.Windows.Forms.Button
        Me.namebox = New System.Windows.Forms.Button
        Me.serid = New System.Windows.Forms.RadioButton
        Me.sername = New System.Windows.Forms.RadioButton
        Me.searchname = New System.Windows.Forms.TextBox
        Me.searchid = New System.Windows.Forms.TextBox
        Me.search = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.year = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.reset = New System.Windows.Forms.Button
        Me.delete = New System.Windows.Forms.Button
        Me.save = New System.Windows.Forms.Button
        Me.dob = New System.Windows.Forms.DateTimePicker
        Me.c_no = New System.Windows.Forms.TextBox
        Me.school = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.female = New System.Windows.Forms.RadioButton
        Me.male = New System.Windows.Forms.RadioButton
        Me.addess = New System.Windows.Forms.TextBox
        Me.fname = New System.Windows.Forms.TextBox
        Me.sname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.searchn_datagrid = New System.Windows.Forms.DataGridView
        Me.searchi_datagrid = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.sid_groupbox.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.searchn_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.searchi_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(563, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Class"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(353, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Session"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Student Id"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(372, 218)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Date Of Join"
        '
        'cdetail
        '
        Me.cdetail.FormattingEnabled = True
        Me.cdetail.Location = New System.Drawing.Point(616, 42)
        Me.cdetail.Name = "cdetail"
        Me.cdetail.Size = New System.Drawing.Size(88, 24)
        Me.cdetail.TabIndex = 3
        '
        'sid
        '
        Me.sid.Location = New System.Drawing.Point(125, 98)
        Me.sid.Name = "sid"
        Me.sid.Size = New System.Drawing.Size(213, 22)
        Me.sid.TabIndex = 4
        '
        'doj
        '
        Me.doj.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.doj.Location = New System.Drawing.Point(491, 216)
        Me.doj.Name = "doj"
        Me.doj.Size = New System.Drawing.Size(213, 22)
        Me.doj.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(360, 472)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 18)
        Me.Label16.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.pcitextbox)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.slctextbox)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Guardian_Emailbox)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Student_Emailbox)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.sid_groupbox)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.year)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.sid)
        Me.GroupBox1.Controls.Add(Me.cdetail)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.doj)
        Me.GroupBox1.Controls.Add(Me.dob)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.c_no)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.school)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.addess)
        Me.GroupBox1.Controls.Add(Me.fname)
        Me.GroupBox1.Controls.Add(Me.sname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(22, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 559)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'pcitextbox
        '
        Me.pcitextbox.Location = New System.Drawing.Point(501, 367)
        Me.pcitextbox.Multiline = True
        Me.pcitextbox.Name = "pcitextbox"
        Me.pcitextbox.Size = New System.Drawing.Size(213, 34)
        Me.pcitextbox.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(362, 367)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(139, 34)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Prevous Coaching" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Institute"
        '
        'slctextbox
        '
        Me.slctextbox.Location = New System.Drawing.Point(196, 367)
        Me.slctextbox.Multiline = True
        Me.slctextbox.Name = "slctextbox"
        Me.slctextbox.Size = New System.Drawing.Size(156, 20)
        Me.slctextbox.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(17, 370)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(174, 17)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Student's Last Class %"
        '
        'Guardian_Emailbox
        '
        Me.Guardian_Emailbox.Location = New System.Drawing.Point(495, 324)
        Me.Guardian_Emailbox.Multiline = True
        Me.Guardian_Emailbox.Name = "Guardian_Emailbox"
        Me.Guardian_Emailbox.Size = New System.Drawing.Size(216, 20)
        Me.Guardian_Emailbox.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(358, 324)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(131, 17)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Guardian's Email"
        '
        'Student_Emailbox
        '
        Me.Student_Emailbox.Location = New System.Drawing.Point(139, 324)
        Me.Student_Emailbox.Multiline = True
        Me.Student_Emailbox.Name = "Student_Emailbox"
        Me.Student_Emailbox.Size = New System.Drawing.Size(213, 20)
        Me.Student_Emailbox.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 324)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 17)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Student's Email"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(139, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 16)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "(EX-Year-Class-Sno)"
        '
        'sid_groupbox
        '
        Me.sid_groupbox.Controls.Add(Me.okbox)
        Me.sid_groupbox.Controls.Add(Me.idbox)
        Me.sid_groupbox.Controls.Add(Me.namebox)
        Me.sid_groupbox.Controls.Add(Me.serid)
        Me.sid_groupbox.Controls.Add(Me.sername)
        Me.sid_groupbox.Controls.Add(Me.searchname)
        Me.sid_groupbox.Controls.Add(Me.searchid)
        Me.sid_groupbox.Controls.Add(Me.search)
        Me.sid_groupbox.Controls.Add(Me.Label15)
        Me.sid_groupbox.Location = New System.Drawing.Point(381, 411)
        Me.sid_groupbox.Name = "sid_groupbox"
        Me.sid_groupbox.Size = New System.Drawing.Size(333, 133)
        Me.sid_groupbox.TabIndex = 17
        Me.sid_groupbox.TabStop = False
        Me.sid_groupbox.Text = "Search By"
        '
        'okbox
        '
        Me.okbox.ForeColor = System.Drawing.Color.Black
        Me.okbox.Location = New System.Drawing.Point(133, 97)
        Me.okbox.Name = "okbox"
        Me.okbox.Size = New System.Drawing.Size(99, 25)
        Me.okbox.TabIndex = 22
        Me.okbox.Text = "OK"
        Me.okbox.UseVisualStyleBackColor = True
        '
        'idbox
        '
        Me.idbox.Location = New System.Drawing.Point(133, 97)
        Me.idbox.Name = "idbox"
        Me.idbox.Size = New System.Drawing.Size(99, 25)
        Me.idbox.TabIndex = 27
        Me.idbox.Text = "OK"
        Me.idbox.UseVisualStyleBackColor = True
        '
        'namebox
        '
        Me.namebox.Location = New System.Drawing.Point(133, 97)
        Me.namebox.Name = "namebox"
        Me.namebox.Size = New System.Drawing.Size(99, 25)
        Me.namebox.TabIndex = 26
        Me.namebox.Text = "OK"
        Me.namebox.UseVisualStyleBackColor = True
        '
        'serid
        '
        Me.serid.AutoSize = True
        Me.serid.Location = New System.Drawing.Point(188, 25)
        Me.serid.Name = "serid"
        Me.serid.Size = New System.Drawing.Size(39, 20)
        Me.serid.TabIndex = 20
        Me.serid.TabStop = True
        Me.serid.Text = "Id"
        Me.serid.UseVisualStyleBackColor = True
        '
        'sername
        '
        Me.sername.AutoSize = True
        Me.sername.Location = New System.Drawing.Point(97, 25)
        Me.sername.Name = "sername"
        Me.sername.Size = New System.Drawing.Size(67, 20)
        Me.sername.TabIndex = 19
        Me.sername.TabStop = True
        Me.sername.Text = "Name"
        Me.sername.UseVisualStyleBackColor = True
        '
        'searchname
        '
        Me.searchname.Location = New System.Drawing.Point(97, 55)
        Me.searchname.Name = "searchname"
        Me.searchname.Size = New System.Drawing.Size(210, 22)
        Me.searchname.TabIndex = 21
        '
        'searchid
        '
        Me.searchid.Location = New System.Drawing.Point(97, 55)
        Me.searchid.Name = "searchid"
        Me.searchid.Size = New System.Drawing.Size(211, 22)
        Me.searchid.TabIndex = 23
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(16, 55)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(73, 23)
        Me.search.TabIndex = 22
        Me.search.Text = "Search"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 17)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Id"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(437, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 15)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "(Ex: 2012-13)"
        '
        'year
        '
        Me.year.Location = New System.Drawing.Point(424, 42)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(133, 22)
        Me.year.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.reset)
        Me.Panel1.Controls.Add(Me.delete)
        Me.Panel1.Controls.Add(Me.save)
        Me.Panel1.Location = New System.Drawing.Point(22, 424)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 83)
        Me.Panel1.TabIndex = 33
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(231, 27)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(99, 29)
        Me.reset.TabIndex = 19
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Location = New System.Drawing.Point(120, 27)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(99, 29)
        Me.delete.TabIndex = 18
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(12, 27)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(99, 29)
        Me.save.TabIndex = 17
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'dob
        '
        Me.dob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dob.Location = New System.Drawing.Point(128, 155)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(210, 22)
        Me.dob.TabIndex = 6
        '
        'c_no
        '
        Me.c_no.Location = New System.Drawing.Point(491, 277)
        Me.c_no.Name = "c_no"
        Me.c_no.Size = New System.Drawing.Size(213, 22)
        Me.c_no.TabIndex = 12
        '
        'school
        '
        Me.school.Location = New System.Drawing.Point(139, 277)
        Me.school.Multiline = True
        Me.school.Name = "school"
        Me.school.Size = New System.Drawing.Size(213, 20)
        Me.school.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.female)
        Me.GroupBox2.Controls.Add(Me.male)
        Me.GroupBox2.Location = New System.Drawing.Point(142, 199)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(163, 58)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'female
        '
        Me.female.AutoSize = True
        Me.female.Location = New System.Drawing.Point(79, 19)
        Me.female.Name = "female"
        Me.female.Size = New System.Drawing.Size(78, 20)
        Me.female.TabIndex = 2
        Me.female.TabStop = True
        Me.female.Text = "Female"
        Me.female.UseVisualStyleBackColor = True
        '
        'male
        '
        Me.male.AutoSize = True
        Me.male.Location = New System.Drawing.Point(16, 19)
        Me.male.Name = "male"
        Me.male.Size = New System.Drawing.Size(60, 20)
        Me.male.TabIndex = 1
        Me.male.TabStop = True
        Me.male.Text = "Male"
        Me.male.UseVisualStyleBackColor = True
        '
        'addess
        '
        Me.addess.Location = New System.Drawing.Point(491, 157)
        Me.addess.Multiline = True
        Me.addess.Name = "addess"
        Me.addess.Size = New System.Drawing.Size(213, 43)
        Me.addess.TabIndex = 7
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(491, 106)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(213, 22)
        Me.fname.TabIndex = 5
        '
        'sname
        '
        Me.sname.Location = New System.Drawing.Point(125, 44)
        Me.sname.Name = "sname"
        Me.sname.Size = New System.Drawing.Size(213, 22)
        Me.sname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Gender"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(372, 277)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Phone-no"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(372, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Father's Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Date Of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(372, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "School"
        '
        'searchn_datagrid
        '
        Me.searchn_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.searchn_datagrid.Location = New System.Drawing.Point(763, 21)
        Me.searchn_datagrid.Name = "searchn_datagrid"
        Me.searchn_datagrid.Size = New System.Drawing.Size(240, 528)
        Me.searchn_datagrid.TabIndex = 24
        '
        'searchi_datagrid
        '
        Me.searchi_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.searchi_datagrid.Location = New System.Drawing.Point(763, 21)
        Me.searchi_datagrid.Name = "searchi_datagrid"
        Me.searchi_datagrid.Size = New System.Drawing.Size(240, 559)
        Me.searchi_datagrid.TabIndex = 25
        '
        'Student_Reg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BackgroundImage = Global.ShreeEducation.My.Resources.Resources.fghg
        Me.ClientSize = New System.Drawing.Size(1007, 599)
        Me.Controls.Add(Me.searchi_datagrid)
        Me.Controls.Add(Me.searchn_datagrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label16)
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1023, 637)
        Me.Name = "Student_Reg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.sid_groupbox.ResumeLayout(False)
        Me.sid_groupbox.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.searchn_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.searchi_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cdetail As System.Windows.Forms.ComboBox
    Friend WithEvents sid As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents doj As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dob As System.Windows.Forms.DateTimePicker
    Friend WithEvents c_no As System.Windows.Forms.TextBox
    Friend WithEvents school As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents female As System.Windows.Forms.RadioButton
    Friend WithEvents male As System.Windows.Forms.RadioButton
    Friend WithEvents addess As System.Windows.Forms.TextBox
    Friend WithEvents fname As System.Windows.Forms.TextBox
    Friend WithEvents sname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents year As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents search As System.Windows.Forms.Label
    Friend WithEvents searchname As System.Windows.Forms.TextBox
    Friend WithEvents sid_groupbox As System.Windows.Forms.GroupBox
    Friend WithEvents searchid As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents searchn_datagrid As System.Windows.Forms.DataGridView
    Friend WithEvents searchi_datagrid As System.Windows.Forms.DataGridView
    Friend WithEvents serid As System.Windows.Forms.RadioButton
    Friend WithEvents sername As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents idbox As System.Windows.Forms.Button
    Friend WithEvents namebox As System.Windows.Forms.Button
    Friend WithEvents okbox As System.Windows.Forms.Button
    Friend WithEvents Student_Emailbox As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Guardian_Emailbox As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents slctextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents pcitextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents reset As System.Windows.Forms.Button
End Class
