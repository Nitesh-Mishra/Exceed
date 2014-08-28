Imports System.Data.Odbc
Public Class Student_Reg
    Dim con As New OdbcConnection("DSN=exceed")


    Private Sub Student_Info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sname.Focus()
        dob.Format = DateTimePickerFormat.Custom
        dob.CustomFormat = "yyyy/MM/dd"

        doj.Format = DateTimePickerFormat.Custom
        doj.CustomFormat = "yyyy/MM/dd"

        searchn_datagrid.Visible = False
        searchi_datagrid.Visible = False
        idbox.Visible = False
        namebox.Visible = False
    End Sub



    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            If sname.Text = "" Or year.Text = "" Or cdetail.Text = "" Or sid.Text = "" Or fname.Text = "" Or dob.Text = "" Or addess.Text = "" Or doj.Text = "" Or school.Text = "" Or c_no.Text = "" Then
                MsgBox("Fields can't left blank.", MsgBoxStyle.Critical)
            Else
                con.Open()
                Dim cmd1 As OdbcCommand
                cmd1 = New OdbcCommand("select * from Student_Info where Student_Id ='" + sid.Text + "'", con)
                If cmd1.ExecuteNonQuery > 0 Then
                    Dim vname, vyear, vdetail, vsid, vfname, vdob, vaddress, vdoj, vschool, vcno, vgender As String
                    vname = sname.Text
                    vyear = year.Text
                    vdetail = cdetail.Text
                    vsid = sid.Text
                    vfname = fname.Text
                    vdob = dob.Text
                    vaddress = addess.Text
                    vdoj = doj.Text
                    vschool = school.Text
                    vcno = c_no.Text
                    If male.Checked = True Then
                        vgender = "Male"
                    Else
                        vgender = "Female"
                    End If
                    Dim cmd As OdbcCommand
                    cmd = New OdbcCommand("update Student_Info set Student_Id='" + vsid + "' ,Year='" + vyear + "',Class='" + vdetail + "',DOJ='" + vdoj + "',Name='" + vname + "',Fname='" + vfname + "',DOB='" + vdob + "',Address='" + vaddress + "',Gender='" + vgender + "',School='" + vschool + "',Phone='" + vcno + "',Student_Email='" + Student_Emailbox.Text + "',Guardian_Email='" + Guardian_Emailbox.Text + "',SLCP='" + slctextbox.Text + "',PCI='" + pcitextbox.Text + "' where Student_Id='" + sid.Text + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Information added Successfully", MsgBoxStyle.Information)
                    sname.Clear()
                    year.Text = ""
                    cdetail.Text = ""
                    sid.Text = ""
                    fname.Clear()
                    dob.Value = Now
                    addess.Clear()
                    doj.Text = ""
                    school.Clear()
                    c_no.Clear()
                    male.Checked = False
                    female.Checked = False
                    Student_Emailbox.Clear()
                    Guardian_Emailbox.Clear()
                    pcitextbox.Clear()
                    slctextbox.Clear()

                Else
                    Dim vname, vyear, vdetail, vsid, vfname, vdob, vaddress, vdoj, vschool, vcno, vgender As String
                    vname = sname.Text
                    vyear = year.Text
                    vdetail = cdetail.Text
                    vsid = sid.Text
                    vfname = fname.Text
                    vdob = dob.Text
                    vaddress = addess.Text
                    vdoj = doj.Text
                    vschool = school.Text
                    vcno = c_no.Text
                    If male.Checked = True Then
                        vgender = "Male"
                    Else
                        vgender = "Female"
                    End If

                    Dim cmd As OdbcCommand
                    cmd = New OdbcCommand("insert into Student_Info (Student_Id,Year,Class,DOJ,Name,FName,DOB,Address,Gender,School,Phone,Student_Email,Guardian_Email,SLCP,PCI) values('" + vsid + "','" + vyear + "','" + vdetail + "','" + vdoj + "','" + vname + "','" + vfname + "','" + vdob + "','" + vaddress + "','" + vgender + "','" + vschool + "','" + vcno + "','" + Student_Emailbox.Text + "','" + Guardian_Emailbox.Text + "','" + slctextbox.Text + "','" + pcitextbox.Text + "')", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Information is Saved", MsgBoxStyle.Information)
                    sname.Clear()
                    year.Text = ""
                    cdetail.Text = ""
                    sid.Text = ""
                    fname.Clear()
                    dob.Value = Now
                    addess.Clear()
                    doj.Text = ""
                    school.Clear()
                    c_no.Clear()
                    male.Checked = False
                    female.Checked = False
                    Student_Emailbox.Clear()
                    Guardian_Emailbox.Clear()
                    pcitextbox.Clear()
                    slctextbox.Clear()

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub



    Private Sub cdetail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cdetail.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            cdetail.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                cdetail.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub sname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sname.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 1 AndAlso Asc(e.KeyChar) <> 3 AndAlso Asc(e.KeyChar) <> 24 AndAlso Asc(e.KeyChar) <> 32 AndAlso Asc(e.KeyChar) <> 46 AndAlso Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 AndAlso Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            MsgBox("Please Enter Alphabets Only", MsgBoxStyle.Critical)
        End If
    End Sub



    Private Sub year_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles year.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso Asc(e.KeyChar) <> 45 Then
            MsgBox("Please enters numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub


    Private Sub sid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sid.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso Asc(e.KeyChar) <> 45 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 AndAlso Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 120 Then
            e.Handled = True
            MsgBox("Don't use Alphanumeric Keys", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub fname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fname.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 1 AndAlso Asc(e.KeyChar) <> 3 AndAlso Asc(e.KeyChar) <> 24 AndAlso Asc(e.KeyChar) <> 32 AndAlso Asc(e.KeyChar) <> 46 AndAlso Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 AndAlso Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            MsgBox("Please Enter Alphabets Only", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub school_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles school.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 1 AndAlso Asc(e.KeyChar) <> 3 AndAlso Asc(e.KeyChar) <> 24 AndAlso Asc(e.KeyChar) <> 32 AndAlso Asc(e.KeyChar) <> 46 AndAlso Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 AndAlso Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            MsgBox("Please Enter Alphabets Only", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub addess_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles addess.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 32 AndAlso Asc(e.KeyChar) <> 44 AndAlso Not IsNumeric(e.KeyChar) AndAlso Asc(e.KeyChar) <> 45 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 AndAlso Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 120 Then
            e.Handled = True
            MsgBox("Don't use Alphanumeric Keys", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub c_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles c_no.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso Asc(e.KeyChar) <> 45 Then
            MsgBox("Please enters numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub




    Private Sub searchid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles searchid.KeyPress
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try

            con.Open()
            Dim cmd As New OdbcCommand
            Dim ds As New DataSet
            Dim test, c, combine As String
            test = searchname.Text
            c = "%"
            combine = test & c
            cmd = New OdbcCommand("Select Student_Id,Name from Student_Info where Student_Id like '" + combine + "' ", con)
            Dim adp As New OdbcDataAdapter(cmd)
            adp.Fill(ds, "Student_Info")
            searchi_datagrid.DataSource = ds
            searchi_datagrid.DataMember = "Student_Info"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        con.Close()
    End Sub

    Private Sub searchname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles searchname.KeyPress
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try

            con.Open()
            Dim cmd As New OdbcCommand
            Dim test, c, combine As String
            test = searchname.Text
            c = "%"
            combine = test & c
            Dim ds As New DataSet
            cmd = New OdbcCommand("Select Name,Student_Id from Student_Info where Name like '" + combine + "' ", con)
            Dim adp As New OdbcDataAdapter(cmd)
            adp.Fill(ds, "Student_Info")
            searchn_datagrid.DataSource = ds
            searchn_datagrid.DataMember = "Student_Info"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        con.Close()
    End Sub


    Private Sub sername_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sername.CheckedChanged
        If sername.Checked = True Then
            namebox.Visible = True
            okbox.Visible = False
            idbox.Visible = False
            searchname.Visible = True
            searchid.Visible = False
            searchn_datagrid.Visible = True
            searchi_datagrid.Visible = False
            searchid.Clear()
            search.Text = "Name"
            searchname.Focus()
        End If
    End Sub

    Private Sub serid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles serid.CheckedChanged
        If serid.Checked = True Then
            idbox.Visible = True
            okbox.Visible = False
            namebox.Visible = False
            searchi_datagrid.Visible = True
            searchn_datagrid.Visible = False
            searchname.Clear()
            search.Text = "Id"
            searchid.Visible = True
            searchname.Visible = False
            searchid.Focus()
        End If
    End Sub

    Private Sub namebox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles namebox.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select * from Student_Info where Name='" + searchname.Text + "' ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                sname.Text = dr(4)
                year.Text = dr(1)
                cdetail.Text = dr(2)
                sid.Text = dr(0)
                fname.Text = dr(5)
                dob.Text = dr(6)
                addess.Text = dr(7)
                doj.Text = dr(3)
                school.Text = dr(9)
                c_no.Text = dr(10)
                If dr(8) = "male" Then
                    male.Checked = True
                End If
                If dr(8) = "female" Then
                    female.Checked = True
                End If
                Student_Emailbox.Text = dr(11)
                Guardian_Emailbox.Text = dr(12)
                slctextbox.Text = dr(13)
                pcitextbox.Text = dr(14)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub idbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idbox.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try

            con.Open()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select * from Student_Info where Student_Id='" + searchid.Text + "' ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                sname.Text = dr(4)
                year.Text = dr(1)
                cdetail.Text = dr(2)
                sid.Text = dr(0)
                fname.Text = dr(5)
                dob.Text = dr(6)
                addess.Text = dr(7)
                doj.Text = dr(3)
                school.Text = dr(9)
                c_no.Text = dr(10)
                If dr(8) = "male" Then
                    male.Checked = True
                End If
                If dr(8) = "female" Then
                    female.Checked = True
                End If
                Student_Emailbox.Text = dr(11)
                Guardian_Emailbox.Text = dr(12)
                slctextbox.Text = dr(13)
                pcitextbox.Text = dr(14)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub searchi_datagrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles searchi_datagrid.CellClick
        searchid.Text = searchi_datagrid.CurrentCell.Value.ToString
    End Sub


    Private Sub cdetail_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cdetail.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            cdetail.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                cdetail.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub cdetail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cdetail.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            cdetail.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                cdetail.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub


    Private Sub searchn_datagrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles searchn_datagrid.CellClick
        searchname.Text = searchn_datagrid.CurrentCell.Value.ToString
    End Sub

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        sname.Clear()
        year.Text = ""
        cdetail.Text = ""
        sid.Text = ""
        fname.Clear()
        dob.Value = Now
        addess.Clear()
        doj.Text = ""
        school.Clear()
        c_no.Clear()
        male.Checked = False
        female.Checked = False
        Student_Emailbox.Clear()
        Guardian_Emailbox.Clear()
        pcitextbox.Clear()
        slctextbox.Clear()
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            If sname.Text = "" Or year.Text = "" Or cdetail.Text = "" Or sid.Text = "" Then
                MsgBox("First select the entry to delete", MsgBoxStyle.Exclamation)
            Else
                Dim studentid, vyear As String
                studentid = sid.Text
                vyear = year.Text
                Dim cmd As OdbcCommand
                Dim intResponse As Integer

                intResponse = MsgBox("Are you sure to delete this record", _
                                     vbYesNo + vbQuestion + vbDefaultButton2, _
                                     "Delete")
                If intResponse = vbYes Then
                    cmd = New OdbcCommand("delete from student_info where student_Id='" + studentid + "' and Year='" + vyear + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Deleted Successfully", MsgBoxStyle.Critical)
                    sname.Clear()
                    year.Text = ""
                    cdetail.Text = ""
                    sid.Text = ""
                    fname.Clear()
                    dob.Value = Now
                    addess.Clear()
                    doj.Text = ""
                    school.Clear()
                    c_no.Clear()
                    male.Checked = False
                    female.Checked = False
                    Student_Emailbox.Clear()
                    Guardian_Emailbox.Clear()
                    pcitextbox.Clear()
                    slctextbox.Clear()
                    searchid.Clear()
                    searchname.Clear()
                    searchn_datagrid.Refresh()
                    searchi_datagrid.Refresh()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

   
End Class