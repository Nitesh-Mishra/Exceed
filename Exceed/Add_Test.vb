
Imports System.Data.Odbc
Public Class Add_Test
    Dim con As New OdbcConnection("DSN=exceed")

    Private Sub cnamecombo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cnamecombo.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            cnamecombo.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                cnamecombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()

    End Sub

    

    Private Sub subidcombo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles subidcombo.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            subidcombo.Items.Clear()
            cmd = New OdbcCommand("select distinct Sub_Id from assign_subject where Class_Detail='" + cnamecombo.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                subidcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub
 
    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        If dot.Text = "" Or cnamecombo.Text = "" Or subidcombo.Text = "" Or mmarks.Text = "" Or testid.Text = "" Then
            MsgBox("Fields can't be left blank", MsgBoxStyle.Critical)
        Else
            Try
                con.Open()
                Dim cname, dat, subid, mm, tid As String
                dat = dot.Text
                cname = cnamecombo.Text
                subid = subidcombo.Text
                mm = mmarks.Text
                tid = testid.Text
                Dim cmd As OdbcCommand
                cmd = New OdbcCommand("insert into Add_Test values ('" + dat + "','" + cname + "','" + subid + "','" + mm + "','" + tid + "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Test is added Successfully", MsgBoxStyle.Information)
                cnamecombo.Text = ""

                subidcombo.Text = ""
                mmarks.Text = ""
                testid.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            con.Close()
        End If
    End Sub

    Private Sub Add_Test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dot.Format = DateTimePickerFormat.Custom
        dot.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub mmarks_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mmarks.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Please enters numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back.Click
        Me.Hide()
        Select_Action.Show()
    End Sub

    Private Sub testid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles testid.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso Asc(e.KeyChar) <> 45 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 AndAlso Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 120 Then
            e.Handled = True
            MsgBox("Don't use Alphanumeric Keys", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub cnamecombo_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cnamecombo.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            cnamecombo.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                cnamecombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub cnamecombo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cnamecombo.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            cnamecombo.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                cnamecombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub subidcombo_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles subidcombo.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            subidcombo.Items.Clear()
            cmd = New OdbcCommand("select distinct Sub_Id from assign_subject where Class_Detail='" + cnamecombo.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                subidcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub subidcombo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles subidcombo.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            subidcombo.Items.Clear()
            cmd = New OdbcCommand("select distinct Sub_Id from assign_subject where Class_Detail='" + cnamecombo.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                subidcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub subidcombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subidcombo.SelectedIndexChanged

    End Sub
End Class