
Imports System.Data.Odbc
Public Class faculty
    Dim con As New OdbcConnection("DSN=exceed")
    Private Sub faculty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
    End Sub


    Private Sub reportbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reportbutton.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            If class_detail.Text = "" And Sub_Id.Text = "" And Yearcombo.Text = "" And facultynamecombobox.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Critical)
            End If
            Module1.myear = yearcombobox.Text
            Module1.mclass = classcombobox.Text
            Module1.msubid = studentidcombobox.Text
            Module1.mfname = facultynamecombobox.Text
            facultyreport.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
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


    Private Sub studentidcombobox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles studentidcombobox.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            studentidcombobox.Items.Clear()
            cmd = New OdbcCommand("select Sub_Id from add_subject where Class_Name='" + classcombobox.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                studentidcombobox.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub studentidcombobox_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles studentidcombobox.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            studentidcombobox.Items.Clear()
            cmd = New OdbcCommand("select Sub_Id from add_subject where Class_Name='" + classcombobox.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                studentidcombobox.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub studentidcombobox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles studentidcombobox.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            studentidcombobox.Items.Clear()
            cmd = New OdbcCommand("select Sub_Id from add_subject where Class_Name='" + classcombobox.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                studentidcombobox.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub facultynamecombobox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles facultynamecombobox.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            facultynamecombobox.Items.Clear()
            cmd = New OdbcCommand("select Faculty_Name from Faculty_Performance where Subject_Id='" + studentidcombobox.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                facultynamecombobox.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub facultynamecombobox_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles facultynamecombobox.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            facultynamecombobox.Items.Clear()
            cmd = New OdbcCommand("select Faculty_Name from Faculty_Performance where Subject_Id='" + studentidcombobox.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                facultynamecombobox.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub facultynamecombobox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles facultynamecombobox.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            facultynamecombobox.Items.Clear()
            cmd = New OdbcCommand("select Faculty_Name from Faculty_Performance where Subject_Id='" + studentidcombobox.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                facultynamecombobox.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub resetbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetbutton.Click
        class_detail.Text = ""
        Yearcombo.Text = ""
        Sub_Id.Text = ""
        facultynametextbox.Clear()
        resultyesradio.Checked = False
        testyesradio.Checked = False
        testnoradio.Checked = False
        remarktextbox.Clear()
        DateTimePicker1.Value = Now
        topictextbox.Clear()
        resultnoradio.Checked = False
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

    Private Sub submitbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submitbutton.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        If Yearcombo.Text = "" Or class_detail.Text = "" Or Sub_Id.Text = "" Or facultynametextbox.Text = "" Or topictextbox.Text = "" Or remarktextbox.Text = "" Then
            MsgBox("Fields can't left blank", MsgBoxStyle.Critical)
        Else
            Try
                con.Open()
                Dim vtest, vresult As String
                If testnoradio.Checked = True Then
                    vtest = "Yes"
                Else
                    vtest = "No"
                End If
                If resultyesradio.Checked = True Then
                    vresult = "Yes"
                Else
                    vresult = "No"
                End If
                Dim cmd As OdbcCommand
                cmd = New OdbcCommand("insert into faculty_Performance values('" + Yearcombo.Text + "','" + class_detail.Text + "','" + Sub_Id.Text + "','" + facultynametextbox.Text + "','" + topictextbox.Text + "','" + DateTimePicker1.Text + "','" + vtest + "','" + vresult + "','" + remarktextbox.Text + "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Information is saved", MsgBoxStyle.Information)
                class_detail.Text = ""
                Yearcombo.Text = ""
                Sub_Id.Text = ""
                facultynametextbox.Clear()
                resultyesradio.Checked = False
                testyesradio.Checked = False
                testnoradio.Checked = False
                remarktextbox.Clear()
                DateTimePicker1.Value = Now
                topictextbox.Clear()
                resultnoradio.Checked = False
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            con.Close()
        End If
    End Sub
End Class