
Imports System.Data.Odbc
Public Class Study_Materialform
    Dim con As New OdbcConnection("DSN=exceed")
    Private Sub sm_savebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sm_savebutton.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        If sm_classcombo.Text = "" Or sm_subcombo.Text = "" Or sm_topictextbox.Text = "" Or sm_yearcombo.Text = "" Then
            MsgBox("Fields can't left blank", MsgBoxStyle.Critical)
        Else
            Try
                Dim cmd As OdbcCommand
                Dim pstatus As String
                If sm_readyradio.Checked = True Then
                    pstatus = "Ready"
                Else
                    pstatus = "Not Ready"
                End If
                con.Open()
                cmd = New OdbcCommand("insert into Study_Material values ('" + sm_yearcombo.Text + "','" + sm_classcombo.Text + "','" + sm_subcombo.Text + "','" + sm_topictextbox.Text + "','" + pstatus + "') ", con)
                cmd.ExecuteNonQuery()
                MsgBox("Information is Saved", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            con.Close()

            Try
                con.Open()
                Dim cmd As New OdbcCommand

                Dim ds As New DataSet
                cmd = New OdbcCommand("Select * from Study_Material where Subject_Id='" + sm_subcombo.Text + "'  ", con)
                Dim adp As New OdbcDataAdapter(cmd)
                adp.Fill(ds, "Study_Material")
                DataGridView1.DataSource = ds
                DataGridView1.DataMember = "Study_Material"
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            con.Close()

        End If

            End Sub

    Private Sub resetbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetbutton.Click
        sm_classcombo.Text = ""
        sm_yearcombo.Text = ""
        sm_subcombo.Text = ""
        sm_topictextbox.Clear()
        sm_notreadyradio.Checked = True
    End Sub

    Private Sub sm_yearcombo_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles sm_yearcombo.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            sm_yearcombo.Items.Clear()
            cmd = New OdbcCommand("select distinct year from student_info ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                sm_yearcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub sm_yearcombo_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles sm_yearcombo.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            sm_yearcombo.Items.Clear()
            cmd = New OdbcCommand("select distinct year from student_info ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                sm_yearcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub sm_yearcombo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles sm_yearcombo.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            sm_yearcombo.Items.Clear()
            cmd = New OdbcCommand("select distinct year from student_info ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                sm_yearcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub sm_classcombo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sm_classcombo.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            sm_classcombo.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                sm_classcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub sm_classcombo_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles sm_classcombo.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            sm_classcombo.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                sm_classcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub sm_classcombo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles sm_classcombo.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            sm_classcombo.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                sm_classcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub


    Private Sub sm_classcombo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sm_classcombo.TextChanged
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As New OdbcCommand
            Dim ds As New DataSet
            cmd = New OdbcCommand("Select * from Study_Material where Class='" + sm_classcombo.Text + "'  ", con)
            Dim adp As New OdbcDataAdapter(cmd)
            adp.Fill(ds, "Study_Material")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "Study_Material"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub sm_subcombo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sm_subcombo.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            sm_subcombo.Items.Clear()
            cmd = New OdbcCommand("select Sub_Id from add_subject where Class_Name='" + sm_classcombo.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                sm_subcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub sm_subcombo_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles sm_subcombo.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            sm_subcombo.Items.Clear()
            cmd = New OdbcCommand("select Sub_Id from add_subject where Class_Name='" + sm_classcombo.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                sm_subcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub sm_subcombo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles sm_subcombo.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            sm_subcombo.Items.Clear()
            cmd = New OdbcCommand("select Sub_Id from add_subject where Class_Name='" + sm_classcombo.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                sm_subcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub sm_subcombo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sm_subcombo.TextChanged
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As New OdbcCommand
            Dim ds As New DataSet
            cmd = New OdbcCommand("Select * from Study_Material where Subject_Id='" + sm_subcombo.Text + "'  ", con)
            Dim adp As New OdbcDataAdapter(cmd)
            adp.Fill(ds, "Study_Material")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "Study_Material"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub


    Private Sub yearcombobox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles yearcombobox.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            yearcombobox.Items.Clear()
            cmd = New OdbcCommand("select distinct year from student_info ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                yearcombobox.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub


    Private Sub classcombobox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles classcombobox.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            classcombobox.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                classcombobox.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub subjectidcombobox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles subjectidcombobox.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            subjectidcombobox.Items.Clear()
            cmd = New OdbcCommand("select Sub_Id from add_subject where Class_Name='" + classcombobox.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                subjectidcombobox.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub subjectidcombobox_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles subjectidcombobox.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
            Dim cmd As OdbcCommand
            subjectidcombobox.Items.Clear()
            cmd = New OdbcCommand("select Sub_Id from add_subject where Class_Name='" + classcombobox.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                subjectidcombobox.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub subjectidcombobox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles subjectidcombobox.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            subjectidcombobox.Items.Clear()
            cmd = New OdbcCommand("select Sub_Id from add_subject where Class_Name='" + classcombobox.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                subjectidcombobox.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub yearcombobox_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles yearcombobox.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            yearcombobox.Items.Clear()
            cmd = New OdbcCommand("select distinct year from student_info ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                yearcombobox.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub yearcombobox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles yearcombobox.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            yearcombobox.Items.Clear()
            cmd = New OdbcCommand("select distinct year from student_info ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                yearcombobox.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub classcombobox_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles classcombobox.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            classcombobox.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                classcombobox.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub classcombobox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles classcombobox.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            classcombobox.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                classcombobox.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub reportbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reportbutton.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            If classcombobox.Text = "" And subjectidcombobox.Text = "" And yearcombobox.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Critical)
            End If
            Module1.myear = yearcombobox.Text
            Module1.mclass = classcombobox.Text
            Module1.msubid = subjectidcombobox.Text
            studymaterialreport.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class