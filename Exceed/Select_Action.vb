Public Class Select_Action


    Private Sub SR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Student_Reg.Show()
    End Sub


    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Student_Reg.Show()
    End Sub

    Private Sub srpic_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles srpic.LinkClicked
        Student_Reg.Show()
    End Sub


    Private Sub acpic_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles acpic.LinkClicked
        Add_Class.Show()
    End Sub

    Private Sub adepic_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles adepic.LinkClicked
        Marks_Data_Entry.Show()
    End Sub

    Private Sub cppic_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Change_Pwd.Show()
    End Sub

    Private Sub atpic_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles atpic.LinkClicked
        Add_Test.Show()
    End Sub

    Private Sub aspiv_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles aspiv.LinkClicked
        assignment.Show()
    End Sub


    Private Sub sfspic_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles sfspic.LinkClicked
        Fees_status.Show()
    End Sub

    Private Sub email_link_label_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles email_link_label.LinkClicked
        emailtest.Show()
    End Sub

    Private Sub Select_Action_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        If musertype = "Operator" Then
            Fees_Status_Link.Enabled = False
            Change_Pwd_Link.Enabled = False
        End If
    End Sub

    Private Sub srpic_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles srpic.MouseHover
        ' select_picturebox.Load(Application.StartupPath & ".Resources\reg.jpeg")
        ' select_picturebox.Image = Image.FromFile(Application.StartupPath & "\shree_edu\reg.jpeg")
        'Label1.Text = "This is student registration link, which let you to register new students or to update the information of previously registered students"
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Reports.Show()
    End Sub

    Private Sub UsersGuideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersGuideToolStripMenuItem.Click
        Process.Start("C:\Users\Nitesh\Desktop\shree.git\UserManual.chm")
    End Sub




    Private Sub StudentRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentRegistrationToolStripMenuItem.Click
        Student_Reg.Show()
    End Sub

    Private Sub AddTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTestToolStripMenuItem.Click
        Add_Test.Show()
    End Sub

    Private Sub AddClassToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddClassToolStripMenuItem.Click
        Add_Class.Show()
    End Sub

    Private Sub AssignSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignSubjectToolStripMenuItem.Click
        assignment.Show()
    End Sub

    Private Sub MarksDataEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarksDataEntryToolStripMenuItem.Click
        Marks_Data_Entry.Show()
    End Sub

    Private Sub StudentFeesStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentFeesStatusToolStripMenuItem.Click
        Fees_status.Show()
    End Sub

    Private Sub EmailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailToolStripMenuItem.Click
        emailtest.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Change_Pwd.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click
        Reports.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        loginForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub


    Private Sub Student_Reg_PictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Student_Reg_PictureBox.Click
        Student_Reg.Show()
    End Sub

    Private Sub Student_Reg_PictureBox_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Student_Reg_PictureBox.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Student_Reg_PictureBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Student_Reg_PictureBox.MouseLeave
        Cursor = Cursors.Arrow
    End Sub

    Private Sub Fees_Status_PictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fees_Status_PictureBox.Click
        Fees_status.Show()
    End Sub

    Private Sub Fees_Status_PictureBox_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fees_Status_PictureBox.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Fees_Status_PictureBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fees_Status_PictureBox.MouseLeave
        Cursor = Cursors.Arrow
    End Sub

    Private Sub Add_Class_PictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_Class_PictureBox.Click
        Add_Class.Show()
    End Sub

    Private Sub Add_Class_PictureBox_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Add_Class_PictureBox.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Add_Class_PictureBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Add_Class_PictureBox.MouseLeave
        Cursor = Cursors.Arrow
    End Sub

    Private Sub Add_Test_PictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_Test_PictureBox.Click
        Add_Test.Show()
    End Sub

    Private Sub Add_Test_PictureBox_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Add_Test_PictureBox.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Add_Test_PictureBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Add_Test_PictureBox.MouseLeave
        Cursor = Cursors.Arrow
    End Sub

    Private Sub Assign_Subject_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Assign_Subject_Link.LinkClicked
        assignment.Show()
    End Sub

    Private Sub Assign_Subject_PictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Assign_Subject_PictureBox.Click
        assignment.Show()
    End Sub

    Private Sub Assign_Subject_PictureBox_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Assign_Subject_PictureBox.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Assign_Subject_PictureBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Assign_Subject_PictureBox.MouseLeave
        Cursor = Cursors.Arrow
    End Sub

    Private Sub Marks_Data_Entry_PictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Marks_Data_Entry_PictureBox.Click
        Marks_Data_Entry.Show()
    End Sub

    Private Sub Marks_Data_Entry_PictureBox_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Marks_Data_Entry_PictureBox.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Marks_Data_Entry_PictureBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Marks_Data_Entry_PictureBox.MouseLeave
        Cursor = Cursors.Arrow
    End Sub

    Private Sub Marks_Data_Entry_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Marks_Data_Entry_Link.LinkClicked
        Marks_Data_Entry.Show()
    End Sub

    Private Sub Email_PictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Email_PictureBox.Click
        emailtest.Show()
    End Sub

    Private Sub Email_PictureBox_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Email_PictureBox.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Email_PictureBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Email_PictureBox.MouseLeave
        Cursor = Cursors.Arrow
    End Sub

    Private Sub Change_Pwd_PictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Change_Pwd_PictureBox.Click
        Change_Pwd.Show()
    End Sub

    Private Sub Change_Pwd_PictureBox_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Change_Pwd_PictureBox.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Change_Pwd_PictureBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Change_Pwd_PictureBox.MouseLeave
        Cursor = Cursors.Arrow
    End Sub

    Private Sub Change_Pwd_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Change_Pwd_Link.LinkClicked
        Change_Pwd.Show()
    End Sub

    Private Sub Report_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Report_Link.LinkClicked
        Reports.Show()
    End Sub

    Private Sub Report_PictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Report_PictureBox.Click
        Reports.Show()
    End Sub

    Private Sub Report_PictureBox_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Report_PictureBox.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Report_PictureBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Report_PictureBox.MouseLeave
        Cursor = Cursors.Arrow
    End Sub

    Private Sub Student_Reg_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Student_Reg_Link.LinkClicked
        Student_Reg.Show()
    End Sub

    Private Sub Fees_Status_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Fees_Status_Link.LinkClicked
        Fees_status.Show()
    End Sub

    Private Sub Add_Class_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Add_Class_Link.LinkClicked
        Add_Class.Show()
    End Sub

    Private Sub Add_Test_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Add_Test_Link.LinkClicked
        Add_Test.Show()
    End Sub

    Private Sub Email_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Email_Link.LinkClicked
        emailtest.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Assignmentform.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        faculty.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Study_Materialform.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Assignmentform.Show()
    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        Cursor = Cursors.Arrow
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        faculty.Show()
    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        Cursor = Cursors.Arrow
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Study_Materialform.Show()
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        Cursor = Cursors.Arrow
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Me.Hide()
        loginForm.Show()
    End Sub

    Private Sub PictureBox5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        Cursor = Cursors.Arrow
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Me.Hide()
        loginForm.Show()
    End Sub
End Class