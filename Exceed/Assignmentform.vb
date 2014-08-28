
Imports System.Data.Odbc
Public Class Assignmentform

    Dim con As New OdbcConnection("DSN=exceed")

    Private Sub assign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles assign.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            If class_detail.Text = "" Or Stud_Id.Text = "" Or Sub_Id.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Critical)
            Else
                Dim vstatus As String
                If yes.Checked = True Then
                    vstatus = "Yes"
                End If
                If no.Checked = True Then
                    vstatus = "No"
                End If
                If incomplete.Checked = True Then
                    vstatus = "Incomplete"
                End If
                Dim cmd As OdbcCommand
                cmd = New OdbcCommand("insert into Assignment values('" + Yearcombo.Text + "','" + class_detail.Text + "','" + Sub_Id.Text + "','" + Submission_Date.Text + "','" + assignmentbox.Text + "','" + Stud_Id.Text + "','" + vstatus + "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Information is Saved", MsgBoxStyle.Information)
                yes.Checked = True
                Stud_Id.Text = ""

            End If

        Catch ex As Exception
            MsgBox("This subject is already assigned to student", MsgBoxStyle.Critical)
        End Try
        con.Close()
    End Sub

    Private Sub class_detail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles class_detail.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            class_detail.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                class_detail.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Stud_Id_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Stud_Id.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Stud_Id.Items.Clear()
            cmd = New OdbcCommand("select Student_Id from Student_Info where Class='" + class_detail.Text + "' ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Stud_Id.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Sub_Id_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sub_Id.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Sub_Id.Items.Clear()
            cmd = New OdbcCommand("select Sub_Id from add_subject where Class_Name='" + class_detail.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Sub_Id.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub


    Private Sub Yearcombo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Yearcombo.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Yearcombo.Items.Clear()
            cmd = New OdbcCommand("select distinct year from student_info ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Yearcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub


    Private Sub mainmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mainmenu.Click
        class_detail.Text = ""
        Stud_Id.Text = ""
        Sub_Id.Text = ""
        assignmentbox.Clear()
        Submission_Date.Value = Now
        yes.Checked = True
        Yearcombo.Text = ""
        Me.Hide()
    End Sub

    Private Sub Yearcombo_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Yearcombo.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Yearcombo.Items.Clear()
            cmd = New OdbcCommand("select distinct year from student_info ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Yearcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Yearcombo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Yearcombo.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Yearcombo.Items.Clear()
            cmd = New OdbcCommand("select distinct year from student_info ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Yearcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub class_detail_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles class_detail.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            class_detail.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                class_detail.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub class_detail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles class_detail.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            class_detail.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                class_detail.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Stud_Id_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Stud_Id.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Stud_Id.Items.Clear()
            cmd = New OdbcCommand("select Student_Id from Student_Info where Class='" + class_detail.Text + "' ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Stud_Id.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Stud_Id_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Stud_Id.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Stud_Id.Items.Clear()
            cmd = New OdbcCommand("select Student_Id from Student_Info where Class='" + class_detail.Text + "' ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Stud_Id.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Sub_Id_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sub_Id.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Sub_Id.Items.Clear()
            cmd = New OdbcCommand("select Sub_Id from add_subject where Class_Name='" + class_detail.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Sub_Id.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub Sub_Id_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sub_Id.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Sub_Id.Items.Clear()
            cmd = New OdbcCommand("select Sub_Id from add_subject where Class_Name='" + class_detail.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Sub_Id.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

End Class