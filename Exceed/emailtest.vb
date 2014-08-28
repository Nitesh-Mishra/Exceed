Imports System.Data.Odbc
Imports System.Net.Mail
Public Class emailtest

    Private Sub sendbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sendbutton.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            Dim mail, atchmail As New MailMessage
            mail.Subject = subjecttextbox.Text
            mail.To.Add(totextbox.Text)
            mail.From = New MailAddress(usernametextbox.Text)
            mail.Body = bodytextbox.Text
            If attachmenttextbox.Text <> "" Then
                Dim attachment As System.Net.Mail.Attachment
                attachment = New System.Net.Mail.Attachment(attachmenttextbox.Text)
                mail.Attachments.Add(attachment)

                Dim smtp As New SmtpClient("smtp.gmail.com")
                smtp.EnableSsl = True
                smtp.Credentials = New System.Net.NetworkCredential(usernametextbox.Text, passwordtextbox.Text)
                smtp.Port = "587"
                smtp.Send(mail)
            Else
                Dim smtp As New SmtpClient("smtp.gmail.com")
                smtp.EnableSsl = True
                smtp.Credentials = New System.Net.NetworkCredential(usernametextbox.Text, passwordtextbox.Text)
                smtp.Port = "587"
                smtp.Send(mail)
            End If

            MsgBox("Message Sent Successfully", MsgBoxStyle.Information)
            totextbox.Clear()
            subjecttextbox.Clear()
            bodytextbox.Clear()
            attachmenttextbox.Clear()
            usernametextbox.Clear()
            passwordtextbox.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        

    End Sub

    Private Sub browsebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browsebutton.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        attachmenttextbox.Text = OpenFileDialog1.FileName
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

    Private Sub class_detail_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles class_detail.SelectedValueChanged
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As New OdbcCommand

            Dim ds As New DataSet
            cmd = New OdbcCommand("Select Student_Id,Student_Email,Guardian_Email from Student_Info where Class='" + class_detail.Text + "'", con)
            Dim adp As New OdbcDataAdapter(cmd)
            adp.Fill(ds, "Student_Info")
            emaildatagrid.DataSource = ds
            emaildatagrid.DataMember = "Student_Info"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        con.Close()
    End Sub

    Private Sub emaildatagrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles emaildatagrid.CellClick
        totextbox.Text = emaildatagrid.CurrentCell.Value.ToString + " , " + totextbox.Text
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

    
End Class