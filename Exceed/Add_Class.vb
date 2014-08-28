
Imports System.Data.Odbc
Public Class Add_Class

    Dim con As New OdbcConnection("DSN=exceed")
    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            If (Class_Name.Text = "" And Sub_Name.Text = "") Or Sub_Id.Text = "" Or Fees.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Critical)
            Else
                con.Open()
                Dim cmd As OdbcCommand
                cmd = New OdbcCommand("select * from Add_Subject where CLass_Name='" + Class_Name.Text + "' and Sub_Id='" + Sub_Id.Text + "'", con)
                If cmd.ExecuteNonQuery > 0 Then
                    Dim vclassname, vsubname, vsubid, vfees As String

                    vclassname = Class_Name.Text
                    vsubname = Sub_Name.Text
                    vsubid = Sub_Id.Text
                    vfees = Fees.Text
                    Dim cmd1 As OdbcCommand
                    If musertype = "Admin" Then
                        cmd1 = New OdbcCommand("update Add_subject set Fees='" + vfees + "' where Class_Name='" + vclassname + "' and Sub_Id='" + vsubid + "'", con)
                        cmd1.ExecuteNonQuery()
                        MsgBox("Fee has been updated", MsgBoxStyle.Information)
                        Class_Name.Clear()
                        Sub_Name.Clear()
                        Sub_Id.Clear()
                        Fees.Clear()
                    Else
                        MsgBox("You do not have rights to update the information", MsgBoxStyle.Critical)
                    End If
                Else
                    Dim vclassname, vsubname, vsubid, vfees As String
                    vclassname = Class_Name.Text
                    vsubname = Sub_Name.Text
                    vsubid = Sub_Id.Text
                    vfees = Fees.Text
                    Dim cmd1 As OdbcCommand
                    cmd1 = New OdbcCommand("insert into Add_Subject values('" + vclassname + "','" + vsubname + "','" + vsubid + "','" + vfees + "')", con)
                    cmd1.ExecuteNonQuery()
                    MsgBox(vsubname & " with Subject Id " & vsubid & " is assigned to class " & vclassname, MsgBoxStyle.Information)
                    Class_Name.Clear()
                    Sub_Name.Clear()
                    Sub_Id.Clear()
                    Fees.Clear()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        con.Close()
    End Sub

    Private Sub Sub_Idcombo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sub_Idcombo.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Sub_Idcombo.Items.Clear()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select Sub_Id from Add_Subject ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Sub_Idcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub


    Private Sub Sub_Idcombo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sub_Idcombo.TextChanged
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            subcombo.Enabled = False
            Class_Name.Enabled = False
            Sub_Name.Enabled = False
            Sub_Id.Enabled = False
            con.Open()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select * from Add_Subject where Sub_Id='" + Sub_Idcombo.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Class_Name.Text = dr(0)
                Sub_Name.Text = dr(1)
                Sub_Id.Text = dr(2)
                Fees.Text = dr(3)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        If (Class_Name.Text = "" And Sub_Name.Text = "") Or Sub_Id.Text = "" Or Fees.Text = "" Then
            MsgBox("Fields can't be left blank", MsgBoxStyle.Critical)
        Else
            Try
                con.Open()
                Dim cmd As OdbcCommand
                Dim intResponse As Integer

                intResponse = MsgBox("Are you sure to delete this record", _
                                     vbYesNo + vbQuestion + vbDefaultButton2, _
                                     "Delete")
                If intResponse = vbYes Then
                    If musertype = "Admin" Then
                        cmd = New OdbcCommand("delete from Add_Subject where Sub_Id='" + Sub_Idcombo.Text + "'", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Subject is deleted", MsgBoxStyle.Critical)
                        Class_Name.Clear()
                        Sub_Name.Clear()
                        Sub_Id.Clear()
                        Fees.Clear()
                        Class_Name.Enabled = True
                        Sub_Name.Enabled = True
                        Sub_Id.Enabled = True
                        Sub_Idcombo.Text = ""
                    Else
                        MsgBox("You do not have rights to delete the information", MsgBoxStyle.Critical)
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        con.Close()
    End Sub

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        subcombo.Text = ""
        Class_Name.Clear()
        Sub_Name.Clear()
        Sub_Id.Clear()
        Fees.Clear()
        Sub_Idcombo.Text = ""
        Class_Name.Enabled = True
        Sub_Name.Enabled = True
        Sub_Id.Enabled = True
        Fees.Enabled = True
    End Sub

    Private Sub Class_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        subradio.Checked = True
        Class_Name.Visible = False
        subcombo.Visible = True
    End Sub

    Private Sub Fees_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Fees.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Please enters numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub Sub_Name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Sub_Name.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 32 AndAlso Asc(e.KeyChar) <> 46 AndAlso Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 AndAlso Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            MsgBox("Please Enter Alphabets Only", MsgBoxStyle.Critical)
        End If
    End Sub


    Private Sub Sub_Id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Sub_Id.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso Asc(e.KeyChar) <> 45 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 AndAlso Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 120 Then
            e.Handled = True
            MsgBox("Don't use Alphanumeric Keys", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Class_Name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Class_Name.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Please enters numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub


    Private Sub classradio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles classradio.CheckedChanged
        If classradio.Checked = True Then

            subcombo.Visible = False
            Class_Name.Visible = True
        End If
    End Sub

    Private Sub subradio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subradio.CheckedChanged
        If subradio.Checked = True Then
            Class_Name.Visible = False
            subcombo.Visible = True
            subcombo.Enabled = True
            Sub_Name.Clear()
            Sub_Id.Clear()
            Fees.Clear()
        End If
    End Sub


    Private Sub subcombo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles subcombo.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            subcombo.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                subcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub


    Private Sub subcombo_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles subcombo.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            subcombo.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                subcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub subcombo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles subcombo.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            subcombo.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                subcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Sub_Idcombo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sub_Idcombo.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Sub_Idcombo.Items.Clear()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select Sub_Id from Add_Subject ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Sub_Idcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Sub_Idcombo_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sub_Idcombo.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Sub_Idcombo.Items.Clear()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select Sub_Id from Add_Subject ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Sub_Idcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    
End Class